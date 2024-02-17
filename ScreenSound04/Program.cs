using (HttpClient client = new()) 
{
    Console.WriteLine("Carregando...");
    try
    {
        Console.Clear();
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        Console.WriteLine(resposta);
    } catch (Exception)
    {
        Console.Clear();
        Console.WriteLine($"Ocorreu um erro: Página não encontrada.");
    }
}