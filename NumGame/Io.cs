using NumGame.Io;

internal class Io : IIo {
    public int GetNumber(string request) {
        while (true) {
            System.Console.Write(request + ": ");
            string? message = Console.ReadLine();

            if (message != null) {
                int number = 0;
                if (int.TryParse(message, out number)) return number;
                else continue;
            }
        }
    }

    public void PrintMessage(string message) {
        System.Console.WriteLine(message); 
    }

    public string GetMessage(string request) {
        while (true) {
            System.Console.Write(request + ": ");
            string? message = Console.ReadLine();
            if (message != null) return message;
        }
    }
}
