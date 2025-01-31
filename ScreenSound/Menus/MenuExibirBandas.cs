using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuExibirBandas : Menu
{
    public override void Executar(Dictionary<string, Banda> dicionarioBandas)
    {
        base.Executar(dicionarioBandas);
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
    }
}
