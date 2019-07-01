namespace P03_StudentSystem
{
    public class Student
    {
        public double Grade { get; set; }

        public int Age { get; set; }

        public string Name { get; set; }

        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }
    }
}