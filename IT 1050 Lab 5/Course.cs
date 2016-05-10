

namespace IT_1050_Lab_5
{
    class Course
    {
        private string courseName;
        private string crnNumber;
        private Student[] studentList;

        public Course(string courseName, string crnNumber, Student[] studentList)
        {
            this.courseName = courseName;
            this.crnNumber = crnNumber;
            this.studentList = studentList;
        }

        public static Course GetCourseInfo()
        {
            System.Console.Write("Please enter the name of the course           : ");

            string courseName = System.Console.ReadLine();
            System.Console.Write("Please enter the course number                : ");
            string crnNumber = System.Console.ReadLine();

            System.Console.Write("How many students are in this course?         : ");
            int studentCount = int.Parse(System.Console.ReadLine());

            Student[] studentList = new Student[studentCount];

            for (int i = 0; i < studentList.Length; i++)
            {
                studentList[i] = new Student();
                System.Console.Write("Student Name:                       : ");
                string studentName = System.Console.ReadLine();
                studentList[i].SetStudentName(studentName);
                System.Console.Write("Student Number                     : ");
                string sNumber = System.Console.ReadLine();
                studentList[i].SetSNumber(sNumber);
            }

            Course course = new Course(courseName, crnNumber, studentList);        

            System.Console.WriteLine();
            System.Console.WriteLine("Course name: " + course.courseName);
            System.Console.WriteLine("Course number: " + course.crnNumber);
            for (int i = 0; i < studentCount; i++)
            {
                System.Console.WriteLine("Student Name: " + studentList[i].GetStudentName() + ", sNumber: " + studentList[i].GetSNumber());
            }
            System.Console.WriteLine();

            return course;
        }
    }
}