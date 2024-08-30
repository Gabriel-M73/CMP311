using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class CalculatorModel
    {
        private double num1;
        private double num2;

        public CalculatorModel()
        {
            num1 = 0;
            num2 = 0;
        } // CalcModel ctor

        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        } // Num1 property

        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        } // Num2 property

        public double DoOperation (string op)
        {
            double result = double.NaN;

            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        } // DoOperation method
    } // CalcModel class
} // calc namespace