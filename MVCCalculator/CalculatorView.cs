using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;

namespace Calculator
{
    class CalculatorView
    {
        public void printString(string str)
        {
            Console.Write(str);
        } // printString method (specifically for Write)

        public void printOptionMenu()
        {
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");
        } // printOptionMenu method

        public string getChar()
        {
            return Console.ReadLine();
        } // getChar method

        public void printResult(double result)
        {
            Console.WriteLine("Your result: {0:0.##}\n", result);
        } // print result method

        public void printMsg(string message)
        {
            Console.WriteLine(message);
        } // printMsg method (specifically for WriteLine)
    } // CalcView class
} // calc namespace
