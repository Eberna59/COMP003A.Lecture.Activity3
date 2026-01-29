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


            
            



        }
    }
}
