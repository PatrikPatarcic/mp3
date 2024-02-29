class MP3PlayerController
{
    private MP3PlayerModel model;
    private MP3PlayerView view;

    public MP3PlayerController()
    {
        model = new MP3PlayerModel();
        view = new MP3PlayerView();
    }

    public void Play()
    {
        string song = "";
        Console.Write("Enter the song name: ");
        song = Console.ReadLine();
        model.Play(song);
    }

    public void Stop()
    {
        model.Stop();
    }

    public void Run()
    {
        while (true)
        {
            string userInput = view.GetUserInput();
            if (userInput == "play")
            {
                Play();
            }
            else if (userInput == "stop")
            {
                Stop();
            }
            else
            {
                view.Display("Invalid command.");
            }
        }
    }
}