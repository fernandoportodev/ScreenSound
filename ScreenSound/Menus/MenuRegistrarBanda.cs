using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> dicionarioBandas)
    {
        base.Executar(dicionarioBandas);
        ExibirTituloOpcoes("REGISTRO DE BANDAS");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new(nomeDaBanda);
        dicionarioBandas.Add(nomeDaBanda, banda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
    }
}