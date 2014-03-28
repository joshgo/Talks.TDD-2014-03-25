using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDConsole
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public int Fibonacci(int n)
        {
            return 1;
        }

        public double DJIA(List<double> p)
        {
            return p.Sum() / GetDivisor();
        }

        public double GetDivisor()
        {
            // Contact a 3rd party service
            //  Website, Service

            return 0.15571590501117;
        }
    }
}
