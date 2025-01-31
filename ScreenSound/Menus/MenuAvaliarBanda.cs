using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> dicionarioBandas)
    {
        base.Executar(dicionarioBandas);
        ExibirTituloOpcoes("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeBanda = Console.ReadLine()!;
        if (dicionarioBandas.ContainsKey(nomeBanda))
        {
            Banda banda = dicionarioBandas[nomeBanda];
            Console.Write($"Qual a nota que a banda {nomeBanda} merece: ");
            Avaliacao notaAvaliacao = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(notaAvaliacao);
            Console.Write($"\nA nota {notaAvaliacao.Nota} foi registrada com sucesso para a banda {nomeBanda}");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nBanda {nomeBanda} não encontrada, tente novamente...");
            Thread.Sleep(2000);
        }
    }
}
