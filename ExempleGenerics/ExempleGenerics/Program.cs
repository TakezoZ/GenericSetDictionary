namespace ExempleGenerics
{
    class Program
    {
        static void Main(string[] Args)
        {
            PrintService printService = new PrintService();

            Console.Write("How many values: ");
            int values = int.Parse(Console.ReadLine());

            for (int i = 0; i < values; i++)
            {
                int value = int.Parse(Console.ReadLine());
                printService.AddValue(value);
            }

            printService.Print();
            Console.WriteLine($"First: {printService.First()}");
        }
    }
}