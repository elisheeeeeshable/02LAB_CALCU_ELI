using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LAB_CALCU_ELI
{
    public delegate I Formula<I>(I arg1, I arg2);
    class CalculatorClass
    {
        public Formula<double> formula;

        public double GetSum(double a, double b)
        {
            return a + b;
        }
        public double GetDifference(double a, double b)
        {
            return a - b;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
        public double GetQuotient(double a, double b)
        {
            if (b == 0)
            {
                return double.NaN; //NaN ibig sabihin Not a Number:)
            }
            return a / b;
        }

        private event Formula<double> calculateEvent;
        public event Formula<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
                calculateEvent += value;
            }
            remove
            {
                Console.WriteLine("Removed the Delegate");
                calculateEvent -= value;
            }
        }
    }
}

    
