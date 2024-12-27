using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internshipAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter the 1st value:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd value:");
            y = int.Parse(Console.ReadLine());
            Calculator c1=new Calculator();
            int additionResullt = c1.Add(x, y);
            int subtractionResult = c1.Subtract(x, y);
            int multiplicationResult=c1.Multiply(x, y);
            
            Console.WriteLine($"The sum is {additionResullt}");
            Console.WriteLine($"The difference is {subtractionResult}");
            Console.WriteLine($"The product is {multiplicationResult}");
            int divisionResult = c1.Divide(x, y);
            Console.WriteLine($"The quotient is {divisionResult}");
        }
    }
}
