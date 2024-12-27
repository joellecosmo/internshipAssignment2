using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internshipAssignment2
{
    internal class Calculator
    {
        public int x { set; get; }
        public int y { set; get; }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            while (y == 0)
            {
                Console.WriteLine("Cannot divide by zero! Enter another value:");
                y = int.Parse(Console.ReadLine());
            }
            return x / y;
        }
    }
    }

