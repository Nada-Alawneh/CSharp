using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Student
            Student s1 = new Student("Nada", 24, "Irbid School", 12, 1001);
            Student s2 = new Student("Ahmad", 20, "Amman School", 11, 1002);

            s1.DisplayPersonInfo();   
            s1.DisplayStudentInfo(); 

            s2.DisplayPersonInfo();
            s2.DisplayStudentInfo();

            Console.WriteLine("---------------");

            // Teacher
            Teacher t1 = new Teacher("Sara", 35, "Irbid School", "Mathematics");
            t1.DisplayTeacherInfo();

            Console.WriteLine("---------------");

            // SchoolReport
            SchoolReport report = new SchoolReport("Final Exam Results");
            report.DisplayReportTitle();

            // errors :
            // Console.WriteLine(s1.SchoolName);   // Error: because its protected access modifier
            // Console.WriteLine(s1._internalCode); // Error: because its private access modifier
        }
    }
}
