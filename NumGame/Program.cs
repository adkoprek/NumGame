using NumGame.Game;

public class Program
{
    private static readonly IGame GameService = new Game();

    static void Main(string[] args) {
        GameService.StartGame();
    }
}
