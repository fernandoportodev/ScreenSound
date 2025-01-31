using ScreenSound.Menus;
using ScreenSound.Modelos;


internal class Program
{
    private static void Main(string[] args)
    {
        // Screen Sound
        string mensagemBoasVindas = "Boas vindas ao Screen Sound";

        Dictionary<string, Banda> dicionarioBandas = new();
        //dicionarioBandas.Add(banda1.Nome, banda1);
        //dicionarioBandas.Add(banda2.Nome, banda2);
        //Banda banda1 = new("Ira");
        //banda1.AdicionarNota(10);
        //banda1.AdicionarNota(9);
        //banda1.AdicionarNota(8);
        //Banda banda2 = new("The Beatles");
        //banda2.AdicionarNota(10);
        //banda2.AdicionarNota(10);
        //banda2.AdicionarNota(10);

        Dictionary<int, Menu> dicionarioMenu = new();
        dicionarioMenu.Add(1, new MenuRegistrarBanda());
        dicionarioMenu.Add(2, new MenuRegistrarAlbum());
        dicionarioMenu.Add(3, new MenuExibirBandas());
        dicionarioMenu.Add(4, new MenuAvaliarBanda());
        dicionarioMenu.Add(5, new MenuExibirDetalhes());
        dicionarioMenu.Add(0, new MenuSair());

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


        void ExibirOpcoesMenu()
        {
            ExibirLogo();
            Console.WriteLine("Digite [1] para registrar uma banda\n");
            Console.WriteLine("Digite [2] para registrar o álbum de uma banda\n");
            Console.WriteLine("Digite [3] para mostrar todas as bandas\n");
            Console.WriteLine("Digite [4] para avaliar uma banda\n");
            Console.WriteLine("Digite [5] para exibir os detalhes de uma banda\n");
            Console.WriteLine("Digite [0] para sair\n");
            Console.Write("Digite a sua opção: ");

            string leituraOpcao = Console.ReadLine()!;
            int opcaoEscolhida = int.Parse(leituraOpcao);

            if(dicionarioMenu.ContainsKey(opcaoEscolhida))
            {
                Menu menuExibido = dicionarioMenu[opcaoEscolhida];
                menuExibido.Executar(dicionarioBandas);
                if (opcaoEscolhida > 0) ExibirOpcoesMenu();
            } else
            {
                Console.WriteLine("Opção inválida");
            }

        }

        ExibirOpcoesMenu();
    }
}