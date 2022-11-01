using ExercicioResolvido.Entities;
using System.Globalization;

namespace ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        set.Add(new LogRecord { Username = line[0], Instant = DateTime.Parse(line[1])});
                    }
                    Console.Write($"Total users: {set.Count}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}