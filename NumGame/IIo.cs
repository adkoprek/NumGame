namespace NumGame.Io;

internal interface IIo {
    public int GetNumber(string request);
    public void PrintMessage(string message);
    public string GetMessage(string request);
}
