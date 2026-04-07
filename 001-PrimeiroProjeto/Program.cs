
class Program
{
    static List<string> nomeBandas = new();

    public static void Main(String[] args)
    {
        int opcao;
        do
        {
            opcao = Menu();
            switch (opcao)
            {
            case 1:
                RegistrarBanda();
                break;
            case 2:
                MostrarBandas();
                break;
            case 3:
                Console.WriteLine("Avaliar uma banda");
                break;
            case 4:
                Console.WriteLine("Exibir a média de uma banda");
                break;
            case 0:
                Console.WriteLine("Saindo...");
                Thread.Sleep(1000);
                break;
            }
        } while (opcao != 0);
        
    }

    static int Menu()
    {
        Console.WriteLine("""

        =========================================================================================================
        ||                                                                                                     ||
        ||    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░    ||
        ||    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗    ||
        ||    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║    ||
        ||    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║    ||
        ||    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝    ||
        ||    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░    ||
        ||                                                                                                     ||
        =========================================================================================================

        Boa vindas ao Screen Sound

        1. registrar uma banda
        2. mostrar todas as bandas
        3. avaliar uma banda
        4. exibir a média de uma banda
        0. sair

        """);

        Console.Write("Digite a sua opção: ");

        string opcaoEscolhida = Console.ReadLine()!;
        int[] opcoes = [0, 1, 2, 3, 4];
        int opcaoEscolhidaNumerica;

        try
        {
            opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            if (!opcoes.Contains(opcaoEscolhidaNumerica))
            {
                throw new System.FormatException();
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Você não digitou uma opção válida!");
            return 0;
        }

        return opcaoEscolhidaNumerica;
    }

    static void RegistrarBanda()
    {
        Console.Clear();
        Console.Write("Registro de bandas\nDigite o nome da banda que deseja registriar: ");
        string nomeBanda = Console.ReadLine()!;
        nomeBandas.Add(nomeBanda);
        Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
        AguardarParaRetornarAoMenu();
    }

    static void MostrarBandas()
    {
        Console.Clear();
        Console.WriteLine("Bandas registradas:");
        nomeBandas.ForEach(banda => Console.WriteLine($"- {banda}"));
        AguardarParaRetornarAoMenu();
    }

    static void AguardarParaRetornarAoMenu()
    {
        Console.WriteLine("\nPressione enter para retornar ao menu...");
        Console.ReadLine();
        Console.Clear();
    }
}