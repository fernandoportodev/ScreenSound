using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> dicionarioBandas)
    {
        Console.WriteLine("Obrigado por usar o ScreenSound! Até a próxima!");
        Thread.Sleep(2000);
        Environment.Exit(0);
    }
}
