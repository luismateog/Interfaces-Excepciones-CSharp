namespace RetoInterfaces;

public sealed class MusicPlayer : IMediaPlayer
{
    private string? current_track;
    private bool isPlaying;

    public void LoadTrack(string track_name)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(track_name);
        current_track = track_name.Trim();
        isPlaying = false;
        Console.WriteLine($"Pista cargada: {current_track}");
    }

    public void Play()
    {
        if (current_track is null)
        {
            Console.WriteLine("No hay ninguna pista cargada.");
            return;
        }
        if (isPlaying)
        {
            Console.WriteLine($"La pista ya está reproduciéndose: {current_track}");
            return;
        }
        isPlaying = true;
        Console.WriteLine($"Reproduciendo: {current_track}");
    }

    public void Pause()
    {
        if (!isPlaying)
        {
            Console.WriteLine("No hay una pista en reproducción para pausar.");
            return;
        }
        isPlaying = false;
        Console.WriteLine($"Pausada: {current_track}");
    }

    public void Stop()
    {
        if (current_track is null)
        {
            Console.WriteLine("No hay ninguna pista cargada.");
            return;
        }
        isPlaying = false;
        Console.WriteLine($"Detenida: {current_track}");
    }

    public string GetCurrentTrack() => current_track ?? "(ninguna pista cargada)";
}
