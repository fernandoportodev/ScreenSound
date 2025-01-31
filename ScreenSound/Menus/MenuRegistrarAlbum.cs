using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> dicionarioBandas)
    {
        base.Executar(dicionarioBandas);
        ExibirTituloOpcoes("Registro de álbuns");
        Console.Write("Digite a banda cujo álbum deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (dicionarioBandas.ContainsKey(nomeDaBanda))
        {
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            Banda banda = dicionarioBandas[nomeDaBanda];
            banda.AdicionarAlbum(new Album(tituloAlbum));
            Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada, tente novamente...");
            Thread.Sleep(2000);
        }
    }
}
