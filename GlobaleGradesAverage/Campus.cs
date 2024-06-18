namespace GlobaleGradesAverage
{
    internal class Campus
    {
        public Student[] students;

        public Campus(Student[] students)
        {
            this.students = students;
        }

        public void DisplayStudents()
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].Name + " - " + ComputeGradePointAverage(students[i]));
            }
        }

        public float ComputeGradePointAverage(Student student)
        {
            float gradePointAverage = student.Grades.Average();
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
