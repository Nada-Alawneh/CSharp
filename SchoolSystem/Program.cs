using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1 – Student Information
            string studentName = "Sami Ali";
            int studentAge = 20;
            int studentGrade = 12;
            double studentAverage = 85.5;
            char studentGender = 'M';
            bool isStudentActive = true;

            Console.WriteLine("===== Student Information =====\n");
            Console.WriteLine("Name:" + studentName);
            Console.WriteLine("Age:" + studentAge);
            Console.WriteLine("Grade:" + studentGrade);
            Console.WriteLine("Average:" + studentAverage);
            Console.WriteLine("Gender:" + studentGender);
            Console.WriteLine("Active:" + isStudentActive);
            Console.WriteLine("\n\n");

            //Part 2 – Multiple Students
            string[] MultipleStudents = { "Nada", "Amneh", "Haya" };
            Console.WriteLine("===== Student Names Before Change  =====\n");
            Console.WriteLine("Student 1 : " + MultipleStudents[0]);
            Console.WriteLine("Student 2 : " + MultipleStudents[1]);
            Console.WriteLine("Student 3 : " + MultipleStudents[2]);
            Console.WriteLine("Number of Students: " + MultipleStudents.Length);

            //Part 3 – Access and Change Array Elements
            Console.WriteLine("\n===== Student Names After Change  =====\n");
            MultipleStudents[0] = "Leen";
            Console.WriteLine("Student 1 : " + MultipleStudents[0]);
            Console.WriteLine("Student 2 : " + MultipleStudents[1]);
            Console.WriteLine("Student 3 : " + MultipleStudents[2]);






        }
    }
}
