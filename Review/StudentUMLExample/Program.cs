using System;

namespace StudentUMLExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student MyStudent = new Student();
            MyStudent.FirstName = "Matt";
            MyStudent.LastName = "Boensch";
            MyStudent.IsONProbation = false;
            MyStudent.SoonerID = 112345678;

            Console.WriteLine(MyStudent);
        }
    }
}
