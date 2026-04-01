class Program
{
    public static int Main(String[] args)
    {
        List<String> names = new List<String>() { "Iago", "José", "Amanda" };

        names.ForEach(name => Console.WriteLine($"Name: {name}"));

        String nome = "Iago Carvalho";
        Console.WriteLine("Olá, " + nome + "!");
        
        return 0;
    }
}