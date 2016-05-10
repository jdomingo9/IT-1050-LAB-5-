

namespace IT_1050_Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("The Course Creator");

            System.Console.Write("Would you like to create a new course? (y/n)  : ");
            string createCourse = System.Console.ReadLine();
            if (createCourse.ToLower().Contains("y"))
            {
                Course course = Course.GetCourseInfo();

                System.Console.Write("Is all the information correct? (y/n)         : ");
                string correctCourseInfo = System.Console.ReadLine();
                while (correctCourseInfo.ToLower().Contains("n"))
                {
                    System.Console.WriteLine("Re-enter course information");
                    course = Course.GetCourseInfo();
                    System.Console.Write("Is all the information correct? (y/n)         : ");
                    correctCourseInfo = System.Console.ReadLine();
                }
            }
            else if (createCourse.ToLower().Contains("n"))
            {
                System.Console.WriteLine("Exiting Program");
            }

            System.Console.WriteLine("Press any key");
            System.Console.ReadKey();
        }
    }
}

       
