Random random = new();

int
    attemptsLeft = 5,
    number = random.Next(1, 11);

Console.WriteLine("Adivinhe o número entre 1 e 10, você possui 5 tentativas, boa sorte...");

int? GetSuggestion()
{
    Console.Write("Digite sua sugestão: ");
    if (!int.TryParse(Console.ReadLine(), out int suggestion))
    {
        Console.WriteLine("Você não digitou um número válido!");
        return null;
    }

    return suggestion;
}

bool CheckSuggestion(int suggestion, bool tip)
{
    if (number == suggestion)
    {
        Console.WriteLine("Parabéns, você adivinhou o número corretamente! ᕙ(  •̀ ᗜ •́  )ᕗ");
        return true;
    }

    if (tip)
    {
        if (number > suggestion)
        {
            Console.WriteLine($"Poxa... O número é maior que {suggestion}");
        }
        else
        {
            Console.WriteLine($"Poxa... O número é menor que {suggestion}");
        }
    }

    return false;
}

do
{
    int? suggestion = GetSuggestion();

    if (suggestion == null)
    {
        Console.WriteLine("Você não digitou um número válido!");
        continue;
    }

    bool gameover = --attemptsLeft == 0 || suggestion == -1;
    if (CheckSuggestion(suggestion ?? 0, !gameover))
    {
        break;
    }

    if (gameover)
    {
        Console.WriteLine($"GAME OVER, o número correto era {number} (ㅠ﹏ㅠ)");
        break;
    }

} while(true);