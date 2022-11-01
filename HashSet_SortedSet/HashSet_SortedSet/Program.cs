namespace HashSet_SortedSet
{
    class Program
    {
        static void Main(string[] Args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Computer"));

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}