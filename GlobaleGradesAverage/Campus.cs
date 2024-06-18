namespace GlobaleGradesAverage
{
    internal class Campus
    {
        public Student[] students;

        public void DisplayStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }

        public float ComputeGradePointAverage(Student student)
        {
            float gradePointAverage = student.Grades.Sum() / student.Grades.Length;
            return gradePointAverage;
        }

        public float ComputeGlobaleGradePointAverage()
        {
            float globaleGradePointAverage = 0.0f;

            foreach (Student student in students)
            {
                globaleGradePointAverage += ComputeGradePointAverage(student);
            }

            globaleGradePointAverage /= students.Length;

            return globaleGradePointAverage;
        }
    }
}
