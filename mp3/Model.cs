class MP3PlayerModel
{
    private string currentSong = "";

    public void Play(string song)
    {
        currentSong = song;
        Console.WriteLine("Playing: " + currentSong);
    }

    public void Stop()
    {
        if (!string.IsNullOrEmpty(currentSong))
        {
            Console.WriteLine("Stopped: " + currentSong);
            currentSong = "";
        }
        else
        {
            Console.WriteLine("No song is currently playing.");
        }
    }
}