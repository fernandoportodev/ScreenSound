using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> dicionarioBandas)
    {
        base.Executar(dicionarioBandas);
        ExibirTituloOpcoes("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (dicionarioBandas.ContainsKey(nomeDaBanda))
        {
            Banda banda = dicionarioBandas[nomeDaBanda];
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
            Console.WriteLine("\nDiscografia:");
            foreach (Album album in banda.Albuns)
            {
                Console.WriteLine($"{album.Nome} -> {album.Media}");
            }
            Console.WriteLine("Digite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada, tente novamente...");
            Thread.Sleep(2000);
        }
    }
}
