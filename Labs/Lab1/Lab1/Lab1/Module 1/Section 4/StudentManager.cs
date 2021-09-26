using System;

namespace Lab1
{
    class StudentManager
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many students in your class?");
            var students = int.Parse(Console.ReadLine()); //get number of students

            var studentData = new string[2, students]; //2D array with # students length and each student entry has a name and grade

            for (int x = 0; x < students; x++)
            {
                Console.WriteLine("Enter student name:");
                studentData[0, x] = Console.ReadLine();

                Console.WriteLine("Enter grade for {0}:", studentData[0, x]);
                studentData[1, x] = Console.ReadLine();
            }

            for (int y = 0; y < students; y++)
            {
                Console.WriteLine("\nName: {0} \nGrade: {1}", studentData[0, y], studentData[1, y]);
            }
        }
    }
}
