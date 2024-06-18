namespace GlobaleGradesAverage
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            Student student1 = new Student("Jean Bombeur", GenerateFiveGrades());
            Student student2 = new Student("Yohan Tonma", GenerateFiveGrades());
            Student student3 = new Student("Sandy Thierry", GenerateFiveGrades());

            Student[] students = { student1, student2, student3 };

            Campus campus = new Campus(students);

            campus.DisplayStudents();

            Console.WriteLine(campus.ComputeGlobaleGradePointAverage());
        }

        public static float[] GenerateFiveGrades()
        {
            float[] grades = new float[5];
            Random random = new Random();

            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = random.NextSingle() * 20;
            }

            return grades;
        }
    }        
}