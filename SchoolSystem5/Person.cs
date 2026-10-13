using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem5
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        protected string SchoolName {  get; set; }

        public Person(string name, int age, string schoolName)
        {
            Name = name;
            Age = age;
            SchoolName = schoolName;
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }


        private string _internalCode; //cannot access from any external class except Person Class
    }
}
