using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_System4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student nada = new Student("Nada", 24, 83.1);
            nada.DisplayInfo();

            Student leen = new Student("Leen", 21, 99);
            leen.DisplayInfo();

            Student yahia  = new Student("yahia", 20, 75.0);
            yahia.DisplayInfo();
        }
    }
}
