internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter A Sambol");
        string Sambol = Console.ReadLine();
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(Sambol);
            }
            Console.WriteLine();
        }
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(Sambol);
            }
            Console.WriteLine();
        }
    }
}