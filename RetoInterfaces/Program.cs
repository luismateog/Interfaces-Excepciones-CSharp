using RetoInterfaces;

Console.WriteLine("=== Reto interfaces: reproductor de música ===");
IMediaPlayer player = new MusicPlayer();
Console.WriteLine($"Pista actual: {player.GetCurrentTrack()}");
((MusicPlayer)player).LoadTrack("Imagine Dragons - Believer");
player.Play();
player.Pause();
player.Play();
player.Stop();
Console.WriteLine($"Pista actual después de detener: {player.GetCurrentTrack()}");
((MusicPlayer)player).LoadTrack("Vivaldi - Primavera");
player.Play();
player.Stop();
