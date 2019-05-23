using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azureTestApp
{
    public class Calculator
    {
        public int sum(int a, int b)
        {
            return a + b;
        }

        public int substract(int a, int b)
        {
            return a - b;
        }

        public int multiply(int a, int b)
        {
            return a * b;
        }

        public double divide(int a, int b)
        {
            return a / b;
        }
    }
}
