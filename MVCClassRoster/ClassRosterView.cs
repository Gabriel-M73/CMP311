using System;
using System.Collections.Generic;
using System.Text;
using MVCClassRoster;

namespace MVCClassRoster
{
    class ClassRosterView
    {
        public String readString()
        {
            return Console.ReadLine();
        } // readString method

        public void writeString(string text)
        {
            Console.WriteLine(text);
        } // writeString method

        public void printRoster(List<Student> roster)
        {
            foreach(Student students in roster)
            {
                Console.WriteLine(students);
            }
        } // printRoster method

    } // ClassRosterView class
} // MVCClassRoster namespace