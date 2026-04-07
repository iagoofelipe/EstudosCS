
class Program
{
    static List<string> nomeBandas = new List<string> { "U2", "The Beatles", "Iron Maiden", "The Neighbourhood" };
    static string separador = "=====================================================================================";

    public static void Main(String[] args)
    {
        int opcao;

        while (true)
        {
            Console.Clear();
            opcao = Menu();

            if (opcao == 0)
                break;

            Console.Clear();

            switch (opcao)
            {
            case 1: RegistrarBanda();
                break;
            case 2: MostrarBandas();
                break;
            case 3: AvaliarBanda();
                break;
            case 4: ExibirMediaBanda();
                break;
            }

            Console.WriteLine("\nPressione qualquer tecla para retornar ao menu...");
            Console.ReadKey();
        } 
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
        Console.Write($"{separador}\n\nRegistro de bandas\n\n{separador}\n\nDigite o nome da banda que deseja registriar: ");
        string nomeBanda = Console.ReadLine()!;
        if (nomeBanda.Length == 0)
        {
            Console.WriteLine("Nenhum valor fornecido!");
            return;
        }

        nomeBandas.Add(nomeBanda);
        Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
        
    }

    static void MostrarBandas()
    {
        Console.WriteLine($"{separador}\n\nBandas registradas\n\n{separador}\n");
        nomeBandas.ForEach(banda => Console.WriteLine($"- {banda}"));
    }

    static void AvaliarBanda()
    {
        Console.WriteLine($"{separador}\n\nAvaliar uma banda\n\n{separador}");
    }

    static void ExibirMediaBanda(string? nomeBanda = null)
    {
        Console.WriteLine($"{separador}\n\nExibir média de uma banda\n\n{separador}");
    }
}