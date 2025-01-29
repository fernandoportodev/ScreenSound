class Musica
{
    public string Nome { get; set; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Plano { get; }
    public string DescricaoResumida => $"{Nome} - {Artista}"; // Lambda expression
    //{
    //    get
    //    {
    //        return $"{Nome} - {Artista}";
    //    }
    //}

    public Musica(string nome, Banda artista, int duracao, bool plano)
    {
        Nome = nome;
        Artista = artista;
        Duracao = duracao;
        Plano = plano;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Plano)
        {
            Console.WriteLine("Disponível no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }

}

