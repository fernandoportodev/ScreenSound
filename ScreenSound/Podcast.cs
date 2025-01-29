class Podcast
{
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;

    private List<Episodio> episodios = new();

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
        Console.WriteLine($"Lista de episódios: {episodios}");
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} com o Host {Host}\n");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem)) 
        {
            Console.WriteLine(episodio.Resumo);
        }

        Console.WriteLine($"Esse podcast possui {TotalEpisodios} episódios");
    }
}