using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: \t\t");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: \t\t");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Addition: \t\t\t" + (num1 + num2));
            Console.WriteLine("Substraction: \t\t\t" + (num1 - num2));
            Console.WriteLine("Multiplication: \t\t" + (num1 * num2));
            Console.WriteLine("Division: \t\t\t" + (num1 / num2));


            Console.ReadLine();
        }
    }
}