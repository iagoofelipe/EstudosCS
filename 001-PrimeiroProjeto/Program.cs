
class Program
{
    public static void Main(String[] args)
    {
        int opcao = Menu();
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
        int[] opcoes = [1, 2, 3, 4];
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

}