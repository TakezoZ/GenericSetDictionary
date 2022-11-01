namespace ExercicioProposto_Set.Entities
{
    internal class Student
    {
        public int Id { get; set; }

        public Student(int id)
        {
            Id = id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Student))
            {
                return false;
            }
            Student other = (Student)obj;
            return Id.Equals(other.Id);
        }
    }
}
