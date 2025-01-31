using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public void Executar(Dictionary<string, Banda> dicionarioBandas)
    {
        base.Executar(dicionarioBandas);
        ExibirTituloOpcoes("Avaliar álbum");
        Console.Write("Digite o nome do álbum que deseja avaliar: ");
        string nomeBanda = Console.ReadLine()!;
        if (dicionarioBandas.ContainsKey(nomeBanda))
        {
            Banda banda = dicionarioBandas[nomeBanda];
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write($"Qual a nota que a banda {nomeBanda} merece: ");
                Avaliacao notaAvaliacao = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(notaAvaliacao);
                Console.Write($"\nA nota {notaAvaliacao.Nota} foi registrada com sucesso para a banda {tituloAlbum}");
                Thread.Sleep(2000);
                Console.Clear();

            }

        }
        else
        {
            Console.WriteLine($"\nBanda {nomeBanda} não encontrada, tente novamente...");
            Thread.Sleep(2000);
        }
    }
}
