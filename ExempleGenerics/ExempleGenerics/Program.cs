namespace ExempleGenerics
{
    class Program
    {
        static void Main(string[] Args)
        {
            PrintService<string> printService = new PrintService<string>();

            Console.Write("How many values: ");
            int values = int.Parse(Console.ReadLine());

            for (int i = 0; i < values; i++)
            {
                string value = Console.ReadLine();
                printService.AddValue(value);
            }

            printService.Print();
            Console.WriteLine($"First: {printService.First()}");
        }
    }
}