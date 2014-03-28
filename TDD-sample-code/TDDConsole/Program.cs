using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample1(args);
        }

        static void Sample1(string[] args)
        {
            // Console.WriteLine("Hello world");

            // How do you test this?
            // The output goes straight to the console

            // TODO: Rewrite as a function
            // TODO: Check the value of a function
            // TODO: Rewrite as a MSTest

            if ("Hello World" == HelloWorld())
            {
                Console.WriteLine("Pass");
            }
            else
                Console.WriteLine("Fail");
        }

        public static string HelloWorld()
        {
            return "Hello World";
        }

        static void Sample2(string[] args)
        {
            var calc = new Calculator();

            // Read in a value
            Console.WriteLine("Enter values: ");
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());

            // Pick an operation
            bool isAdd = Console.ReadLine() == "+";

            // Apply operation
            double result = 0;

            if (isAdd)
                result = calc.Add(a, b);
            else
                result = calc.Subtract(a, b);

            // Display the result
            Console.WriteLine("{0} + {1} = {2}", a, b, result);

            // TODO: Rewrite as a function
            // TODO: Check the value of a function
            // TODO: Rewrite as a MSTest
        }
    }
}
