using System;
using System.Collections.Generic;
using System.Text;
using MVCClassRoster;

namespace MVCClassRoster
{
    class ClassRosterController
    {
        ClassRosterModel myModel = new ClassRosterModel();
        ClassRosterView myView = new ClassRosterView();

        bool appFlag = true;

        public ClassRosterController()
        {
            myView.writeString("Console Calculator in C#\r");
            myView.writeString("---------------------\n");

            myView.writeString("Enter first name for the instructor");
            String fName = myView.readString(); // instructor first name holder variable
            myView.writeString("Enter last name for the instructor");
            String lName = myView.readString(); // instructor last name holder variable
            myView.writeString("Enter contact info for the instructor");
            String cInfo = myView.readString(); // instructor contact info holder variable
            myModel.addInstructor(fName, lName, cInfo); // adding an instructor to the roster

            while (appFlag) // while loop checking appFlag value
            {
                myView.writeString("1: Add a student.");
                myView.writeString("2: Print the class roster.");
                myView.writeString("3: Quit application.\n");
                // menu for the user to pick a prompt
                myView.writeString("Please enter an option");
                string userInput = myView.readString(); // stores the users input for the prompt

                if(userInput == "1") // if statement checking if user inputted "1" to add a student
                {
                    myView.writeString("Enter the student's first name");
                    String sFName = myView.readString(); // student first name holder variable

                    String sLName = ""; // student last name holder variable
                    while (sLName == "")
                    {
                        myView.writeString("Enter the student's last name");
                        sLName = myView.readString();
                        if (sLName == "")
                        {
                            myView.writeString("Try Again");
                        } // if statement checking for a last name and prompting again if needed
                    } // while loop checking for if a last name was entered for student

                    String cRank = ""; // student class rank holder variable
                    while (cRank == "")
                    {
                        myView.writeString("Enter the student's class rank");
                        cRank = myView.readString();
                        if (cRank == "")
                        {
                            myView.writeString("Try Again");
                        } // if statement checking for a class rank and prompting again if needed
                    } // while loop checking for if a class rank was entered for student

                    myModel.addStudent(sFName, sLName, cRank); // add a student to the roster
                } // if statement checking if user inputted "1" to add a student
                
                else if(userInput == "2") 
                {
                    myView.writeString(Convert.ToString(myModel.getInstructor()));
                    myView.printRoster(myModel.getStudentRoster());
                    myView.writeString("--------------------------\n");
                } // else if statement checking if user inputted "2" to print out the roster

                else if (userInput == "3") 
                {
                    myView.writeString("Quitting out of application");

                    appFlag = false;
                } //else if statement checking if user inputted "3" to quit out application
                
                else
                {
                    myView.writeString("Invalid Input");
                } // else statement for an invalid input

            } // while loop checking app flag value

        } // ClassRosterController ctor
    } // ClassRosterController class
} // MVCClassRoster namespace