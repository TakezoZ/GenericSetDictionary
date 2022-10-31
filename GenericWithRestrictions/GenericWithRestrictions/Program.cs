using GenericWithRestrictions.Entities;
using GenericWithRestrictions.Services;
using System.Globalization;

namespace GenericWithRestrictions
{
    class Program
    {
        static void Main(string[] Args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] product = Console.ReadLine().Split(',');
                list.Add(new Product(product[0], double.Parse(product[1],CultureInfo.InvariantCulture)));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("Max:");
            Console.WriteLine(max);
        }
    }
}