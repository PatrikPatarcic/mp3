class MP3PlayerView
{
    public void Display(string message)
    {
        Console.WriteLine(message);
    }

    public string GetUserInput()
    {
        Console.Write("Enter command (play/stop): ");
        return Console.ReadLine();
    }
}
