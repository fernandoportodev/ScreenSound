// Screen Sound
string mensagemBoasVindas = "Boas vindas ao Screen Sound";

Dictionary<string, List<int>> dicionarioBandas = new Dictionary<string, List<int>>();

void ExibirLogo()
{
    Console.WriteLine(mensagemBoasVindas);
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
}
void ExibirTituloOpcoes(string titulo)
{
    int qtdLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtdLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine($"{asteriscos} \n");

}

void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("Digite [1] para registrar uma banda\n");
    Console.WriteLine("Digite [2] para exibir todas as bandas\n");
    Console.WriteLine("Digite [3] para avaliar uma banda\n");
    Console.WriteLine("Digite [4] para exibir a média de uma banda\n");
    Console.WriteLine("Digite [0] para sair\n");
    Console.Write("Digite a sua opção: ");

    string leituraOpcao = Console.ReadLine()!;
    int opcaoEscolhida = int.Parse(leituraOpcao);
    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ExibirBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibirMediaAvaliacoesBanda();
            break;
        case 0:
            Console.WriteLine($"Você escolheu a opção {opcaoEscolhida}");
            Console.WriteLine($"Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;

    }
}


void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloOpcoes("REGISTRO DE BANDAS");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    dicionarioBandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void ExibirBandas()
{
    Console.Clear();
    ExibirTituloOpcoes("EXIBIÇÃO DE BANDAS REGISTRADAS");
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"\nBanda: {listaDasBandas[i]}");
    //}

    foreach (string banda in dicionarioBandas.Keys)
    {
        Console.WriteLine($"\nBanda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal...");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();

}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloOpcoes("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (dicionarioBandas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeBanda} merece: ");
        int notaAvaliacao = int.Parse(Console.ReadLine()!);
        if (notaAvaliacao <= 10)
        {
            dicionarioBandas[nomeBanda].Add(notaAvaliacao);
            Console.Write($"\nA nota {notaAvaliacao} foi registrada com sucesso para a banda {nomeBanda}");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesMenu();
        } else
        {
            Console.WriteLine("Apenas notas de 0 a 10 são aceitas, tente novamente...");
            Thread.Sleep(2000);
            AvaliarBanda();

        }
    } else
    {
        Console.WriteLine($"\nBanda {nomeBanda} não encontrada, tente novamente...");
        Thread.Sleep(2000);
        AvaliarBanda();
    }
}

void ExibirMediaAvaliacoesBanda()
{
    Console.Clear();
    ExibirTituloOpcoes("Exibindo média de avaliações da Banda");
    Console.Write("Digite o nome da banda que verificar a média das avaliações: ");
    string nomeBanda = Console.ReadLine()!;
    if(dicionarioBandas.ContainsKey(nomeBanda))
    {
        double mediaAvaliacoes = dicionarioBandas[nomeBanda].Average();
        Console.WriteLine($"A média de avaliações da Banda {nomeBanda} é de: {mediaAvaliacoes}");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal...");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    } else
    {
        Console.WriteLine($"\nBanda {nomeBanda} não encontrada, tente novamente...");
        Thread.Sleep(2000);
        ExibirMediaAvaliacoesBanda();
    }
}

ExibirOpcoesMenu();


