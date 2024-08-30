using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    class CalculatorController
    {
        CalculatorModel myModel = new CalculatorModel();
        CalculatorView myView = new CalculatorView();

        bool closeApp = false;

        public CalculatorController()
        {
            while (!closeApp)
            {
                // Display title as the C# console calculator app.
                myView.printMsg("Console Calculator in C#\r");
                myView.printMsg("------------------------\n");

                // Declare variables and set to empty.
                // Use Nullable types (with ?) to match type of System.Console.ReadLine
                string? numInput1 = "";
                string? numInput2 = "";
                double result = 0;

                // Ask the user to type the first number
                myView.printString("Type a number, and then press Enter: ");
                numInput1 = myView.getChar();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    myView.printString("This is not valid input. Please enter a numeric value: ");
                    numInput1 = myView.getChar();
                } // while loop checking for a valid input for numInput1
                myModel.Num1 = Convert.ToDouble(numInput1);

                // Ask the user to type the second number.
                myView.printString("Type another number, and then press Enter: ");
                numInput2 = myView.getChar();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    myView.printString("This is not valid input. Please enter a numeric value: ");
                    numInput2 = myView.getChar();
                } // while loop checking for valid input for numInput2
                myModel.Num2 = Convert.ToDouble(numInput2);

                myView.printOptionMenu();
                string? op = myView.getChar();

                // Validate input is not null, and matches the pattern
                if (op == null || !Regex.IsMatch(op, "[a|s|m|d]"))
                {
                    myView.printMsg("Error: Unrecognized input.");
                }
                else
                {
                    try
                    {
                        result = myModel.DoOperation(op);
                        if (double.IsNaN(result))
                        {
                            myView.printMsg("This operation will result in a mathematical error.\n");
                        }
                        else myView.printResult(result);
                    }
                    catch (Exception e)
                    {
                        myView.printMsg("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                    }
                }
                myView.printMsg("------------------------\n");

                // Wait for the user to respond before closing.
                myView.printString("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (myView.getChar() == "n") closeApp = true;

                myView.printMsg("\n"); // Friendly linespacing.
            } // while loop closeApp
            return;
        }// CalcController ctor
    } // CalcController class
} // calc namespace