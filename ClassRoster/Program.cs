using System;
using System.Collections.Generic;
// commit and push for video

namespace ClassRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            bool appFlag = true;
            Console.WriteLine("ClassRoster App in C#");
            Console.WriteLine("---------------------\n");

            Instructor myInstructor = new Instructor(); // creating a new instructor

            Console.WriteLine("Enter first name for the instructor");
            myInstructor.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name for the instructor");
            myInstructor.LastName = Console.ReadLine();
            Console.WriteLine("Enter contact info for the instructor");
            myInstructor.ContactInfo = Console.ReadLine();

            List<Student> studentsList = new List<Student>(); // creating a list for the student info to be stored in
            List<Student> sortedStudentsList = new List<Student>(); //creating sorted list to add students to in order

            while (appFlag)
            {
                Console.WriteLine("1: Add a student.");
                Console.WriteLine("2: Print the class roster.");
                Console.WriteLine("3: Quit application.\n");
                // menu for the user to pick a prompt
                Console.WriteLine("Please enter an option");
                string userInput = Console.ReadLine(); // stores the users input for the prompt

                if (userInput == "1") // if statement checking if user inputted "1" to add a student
                {
                    Student myStudent = new Student(); // creates a new student instance
                    Console.WriteLine("Enter the student's first name");
                    myStudent.FirstName = Console.ReadLine();
                    while (myStudent.LastName == "")
                    {
                        Console.WriteLine("Enter the student's last name");
                        myStudent.LastName = Console.ReadLine();
                        if (myStudent.LastName == "")
                        {
                            Console.WriteLine("Try Again");
                        } // if statement checking for a last name and prompting again if needed
                    } // while loop checking for if a last name was entered for student
                    while (myStudent.ClassRank == "")
                    {
                        Console.WriteLine("Enter the student's class rank");
                        myStudent.ClassRank = Console.ReadLine();
                        if (myStudent.ClassRank == "")
                        {
                            Console.WriteLine("Try Again");
                        } // if statement checking for if a class rank was entered for student
                    } // while loop checking for if a class rank was entered for student
                    studentsList.Add(myStudent); // add student to unsorted list
                    sortedStudentsList.Add(myStudent); // add student to sorted list
                    Console.WriteLine("--------------------------\n");
                } // if statement checking if user inputted "1" to add a student

                else if (userInput == "2") // else if statement checking if user inputted "2" to print out the roster
                {
                    Console.WriteLine("Pick an option to print"); // begin menu for roster printing
                    Console.WriteLine("1: Print out roster as inputted");
                    Console.WriteLine("2: Print out roster sorted by student's last names");
                    Console.WriteLine("3: Print out roster sorted by student's class ranks");
                    Console.WriteLine("Please enter an option");
                    string rosterInput = Console.ReadLine(); // stores user input for roster printing

                    if (rosterInput == "1") // print out roster as inputted option
                    {
                        Console.WriteLine(myInstructor); // print instructor first

                        foreach (Student myStudent in studentsList)
                        {
                            Console.WriteLine(myStudent);
                        } // foreach loop to print out studentList
                        Console.WriteLine("--------------------------\n");
                    } // print out roster as inputted option

                    else if(rosterInput == "2") // print roster sorted by last name option
                    {
                        sortedStudentsList.Sort((x, y) => string.Compare(x.LastName, y.LastName)); // lambda expression to sort out the sortedStudentsList by last names

                        Console.WriteLine(myInstructor); // print instructor first

                        foreach (Student myStudent in sortedStudentsList)
                        {
                            Console.WriteLine(myStudent);
                        } // foreach loop to print out sortedStudentList
                        Console.WriteLine("--------------------------\n");
                    } // print roster sorted by last name option

                    else if (rosterInput == "3") // print roster sorted by class rank option
                    {
                        sortedStudentsList.Sort((x, y) => string.Compare(x.ClassRank, y.ClassRank)); // lambda expression to sort out the sortedStudentsList by class ranks

                        Console.WriteLine(myInstructor); // print instructor first

                        foreach (Student myStudent in sortedStudentsList)
                        {
                            Console.WriteLine(myStudent);
                        } // foreach loop to print out sortedStudentList
                        Console.WriteLine("--------------------------\n");
                    } // print roster sorted by class rank option

                    else // user inputted an invalid option
                    {
                        Console.WriteLine("Invalid Input");
                    } // user inputted an invalid option

                } // else if statement checking if user inputted "2" to print out the roster

                else if (userInput == "3") //else if statement checking if user inputted "3" to quit out application
                {
                    Console.WriteLine("Quitting out of application");
         
                    appFlag = false;
                } //else if statement checking if user inputted "3" to quit out application

                else // else statement for an invalid input
                {
                    Console.WriteLine("Invalid Input");
                } // else statement for an invalid input
            } // while loop check appFlag
        } // Main
    } // Program
} // ClassRoster namespace