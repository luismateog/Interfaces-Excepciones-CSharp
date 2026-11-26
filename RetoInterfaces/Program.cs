using RetoInterfaces;

Console.WriteLine("=== Reto interfaces: reproductor de música ===");
MusicPlayer player = new();
Console.WriteLine($"Pista inicial: {player.GetCurrentTrack()}");
player.Play();
player.LoadTrack("Imagine Dragons - Believer");
player.Play();
Console.WriteLine($"Pista actual: {player.GetCurrentTrack()}");
player.Pause();
player.Play();
player.Stop();
player.LoadTrack("Vivaldi - Primavera");
player.Play();
player.Stop();
Console.WriteLine($"Pista final: {player.GetCurrentTrack()}");

