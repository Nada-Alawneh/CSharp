using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchoolSystem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //part 1: 
            Console.WriteLine("Plz,enter your information :");

            Console.WriteLine("Enter your Name :");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter your Age :");
            int studentAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Grade :");
            double studentGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your Average :");
            double studentAvg = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your Gender :");
            char studentGender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();

            //part 2:
            Console.WriteLine("===== Student Report =====");
            Console.WriteLine($"Welcome {studentName} !");
            Console.WriteLine($"Name : {studentName} ");
            Console.WriteLine($"Age : {studentAge} ");
            Console.WriteLine($"Grade : {studentGrade} ");
            Console.WriteLine($"Average : {studentAvg} ");
            Console.WriteLine($"Gender : {studentGender} ");

            Console.WriteLine();

            //part 3:
            Console.WriteLine("===== Name Information =====");
            Console.WriteLine($"Original Name : {studentName} ");
            Console.WriteLine("Uppercase: " + studentName.ToUpper());
            Console.WriteLine("Lowercase: " + studentName.ToLower());
            Console.WriteLine("First Letter: " + studentName[0]);

            Console.WriteLine();

            //part 4:
            int BonusMarks = 5;
            Console.WriteLine($"Average : {studentAvg}");
            Console.WriteLine($"Bonus Marks :{BonusMarks}");
            double BonusGrade = studentAvg + BonusMarks;
            Console.WriteLine($"New Average :{BonusGrade}");

            Console.WriteLine();



            //part 5:
            if (BonusGrade >= 50)
            {
                Console.WriteLine("Result: Passed");
            }
            else
            {
                Console.WriteLine("Result: Failed");
            }
            

            if (studentAge >= 18)
            {
                Console.WriteLine("Age :Adult");
            }
            else
            {
                Console.WriteLine("Age :underAge");
            }
















        }
    }
}
