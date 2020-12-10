
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public static class CalculatorLogic
    {
        public static double Calculate(double value1, double value2, string operation)
        {
            double result = 0;

            switch (operation)
            {
                case "divide":
                    result = value1 / value2;
                    break;
                case "multiply":
                    result = value1 * value2;
                    break;
                case "plus":
                    result = value1 + value2;
                    break;
                case "minus":
                    result = value1 - value2;
                    break;
            }

            return result;
        }
    }
}