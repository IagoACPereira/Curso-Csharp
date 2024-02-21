using ScreenSound04.Modelos;
using System.Text.Json;
using ScreenSound04.Filtros; 

using (HttpClient client = new()) 
{
    Console.WriteLine("Carregando...");
    try
    {
        Console.Clear();
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
    } catch (Exception)
    {
        Console.Clear();
        Console.WriteLine($"Ocorreu um erro: Página não encontrada.");
    }
}