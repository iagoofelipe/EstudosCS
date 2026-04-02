class Program
{
    public static void Main(String[] args)
    {
        Random random = new();

        int
            attemptsLeft = 5,
            number = random.Next(1, 11);

        Console.WriteLine("Adivinhe o número entre 1 e 10, você possui 5 tentativas, boa sorte...");

        do
        {
            int? suggestion = GetSuggestion();

            if (suggestion == null)
                continue;

            bool gameover = --attemptsLeft == 0 || suggestion == -1;
            if (CheckSuggestion(number, suggestion ?? 0, !gameover))
                break;

            if (gameover)
            {
                Console.WriteLine($"GAME OVER, o número correto era {number} (ㅠ﹏ㅠ)");
                break;
            }

        } while(true);
    }

    static int? GetSuggestion()
    {
        Console.Write("Digite sua sugestão: ");
        if (!int.TryParse(Console.ReadLine(), out int suggestion))
        {
            Console.WriteLine("Você não digitou um número válido!");
            return null;
        }

        return suggestion;
    }

    static bool CheckSuggestion(int number, int suggestion, bool tip)
    {
        if (number == suggestion)
        {
            Console.WriteLine("Parabéns, você adivinhou o número corretamente! ᕙ(  •̀ ᗜ •́  )ᕗ");
            return true;
        }

        if (tip)
            Console.WriteLine($"Poxa.. O número é {(number > suggestion? "maior" : "menor")} que {suggestion}");

        return false;
    }
}

