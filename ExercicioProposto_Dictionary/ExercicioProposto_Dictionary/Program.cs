namespace ExercicioProposto_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> canditates = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] votingRecord = sr.ReadLine().Split(',');
                        string candidate = votingRecord[0];
                        int votes = int.Parse(votingRecord[1]);

                        if (canditates.ContainsKey(candidate))
                        {
                            canditates[candidate] += votes;
                        }
                        else
                        {
                            canditates[candidate] = votes;
                        }
                        
                    }
                    foreach (KeyValuePair<string, int> candidate in canditates)
                    {
                        Console.WriteLine($"{candidate.Key}: {candidate.Value}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}