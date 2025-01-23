using NumGame.Io;
using NumGame.Game;
using NumGame.Constants;

internal class Game : IGame {
    private int Level { get; set; }
    private IIo IoInterface { get; init; }
    private Random RandomGenerator { get; init; }

    public Game() {
        IoInterface = new Io();
        RandomGenerator = new Random();
    }

    public void StartGame() {
        while (true) {
            ChooseLevel();
            Round();
            while (true) {
                string message = IoInterface.GetMessage("You want to play? (Yes/No)").ToLower();
                if (message == "no") return;
                if (message == "yes") break;
            }
        }
    }

    private void ChooseLevel() {
        while (true) {
            IoInterface.PrintMessage("- 1: 1 - 10");
            IoInterface.PrintMessage("- 2: 1 - 20");
            IoInterface.PrintMessage("- 3: 1 - 30");
            IoInterface.PrintMessage("- 4: 1 - 35");
            IoInterface.PrintMessage("- 5: 1 - 40");
            Level = IoInterface.GetNumber("Choose a level");
            if (!Constants.LEVELS.ContainsKey(Level)) 
                IoInterface.PrintMessage("Choose one of the available levels");
            else return;
        }
    }

    private void Round() {
        int ToGuess = RandomGenerator.Next(Constants.LEVELS[Level][0], Constants.LEVELS[Level][1]);

        for (int i = 0; i < 3; i++) {
            int Guessed = IoInterface.GetNumber("Guess a number");

            if      (Guessed > ToGuess) IoInterface.PrintMessage("You guess to heigh");
            else if (Guessed < ToGuess) IoInterface.PrintMessage("You guess to low");
            else {
                IoInterface.PrintMessage("You won");
                return;
            }
        }

        IoInterface.PrintMessage($"You lost womp womp, the number was: {ToGuess}");
    }

}
