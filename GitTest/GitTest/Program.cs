using GitTest.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            c.RightValue = 5;
            c.LeftValue = 10;
            Console.WriteLine(c.Add());
            Console.WriteLine(c.Substract());
            Console.ReadLine();
        }
    }
}
