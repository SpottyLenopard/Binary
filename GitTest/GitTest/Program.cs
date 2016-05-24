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
            Console.WriteLine(Multiply());
            //show result
            Console.ReadLine();
        }

        public static int Multiply()
        {
            Calc c1 = new Calc();
            Calc c2 = new Calc();
            c1.RightValue = c1.LeftValue = c2.RightValue = c2.LeftValue = 5;
            return c1.Add() * c2.Add();
        }
    }
}
