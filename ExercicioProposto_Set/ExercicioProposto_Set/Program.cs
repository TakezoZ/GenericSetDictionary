using ExercicioProposto_Set.Entities;
using ExercicioProposto_Set.Entities.Enums;

namespace ExercicioProposto_Set
{
    class Program
    {
        static void Main(string[] Args)
        {
            HashSet<Student> set = new HashSet<Student>();

            Courses course = Courses.A;

            while (course <= Courses.C)
            {
                Console.Write($"How many students for course {course}?: ");
                int a = int.Parse(Console.ReadLine());
                for (int i = 0; i < a; i++)
                {
                    set.Add(new Student(int.Parse(Console.ReadLine())));
                }
                course++;
            }
            Console.Write($"Total students: {set.Count}");
        }
    }
}