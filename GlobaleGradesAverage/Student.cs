namespace GlobaleGradesAverage
{
    internal class Student
    {
        public string Name { get; set; }
        public float[] Grades { get; set; }
        public void SpeakWith(Student student)
        {
            Console.WriteLine($"Hi {student.Name}. How are you today?");
        }

        public void YellAt(Student student)
        {
            Console.WriteLine($"{student.Name}! Come here!");
        }
    }
}
