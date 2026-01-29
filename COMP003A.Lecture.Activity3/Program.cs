using System.Net.Http.Headers;

namespace COMP003A.Lecture.Activity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Section A: Academic Term Identification");

            int currentMonth = DateTime.Now.Month;

            Console.WriteLine("Current Month" + currentMonth);

            if (currentMonth >= 1 && currentMonth <= 5)
            {
                Console.WriteLine("Spring Term");
            }

            else if (currentMonth == 6 || currentMonth == 7)

            {
                Console.WriteLine("Summer Term");
            }

            else
            {
                Console.WriteLine("Fall Term");
            }

            Console.WriteLine();

            Console.WriteLine("Section B: Campus Access Check");

            Console.WriteLine("Enter your Age: ");

            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Are you currently enrolled? (yes/no): ");
            bool isEnrolled = Console.ReadLine().ToLower() == "true";

            Console.WriteLine("Do you have a student ID? (yes/no): ");
            bool hasStudentId = Console.ReadLine().ToLower() == "true";

            if (age >= 18)
            {
                if (isEnrolled || hasStudentId)
                {
                    Console.WriteLine("Campus Access Granted");
                }
                else
                {
                    Console.WriteLine("Campus Access Denied");
                }
            }
            else
            {
                Console.WriteLine("Campus Access Denied");
            }

            Console.WriteLine();

            Console.WriteLine("Section C: Semester Code lookup");

            Console.WriteLine("Enter a semester code (SP, SU, FA): ");
            string semesterCode = Console.ReadLine();

            switch (semesterCode)
            {
                case "SP":
                    Console.WriteLine("Spring");
                    break;

                case "SU":
                    Console.WriteLine("Summer");
                    break;

                case "FA":
                    Console.WriteLine("Fall");
                    break;

                default:
                    Console.WriteLine("Invalid semester code");
                    break;
            }


           
            



        }
    }
}
