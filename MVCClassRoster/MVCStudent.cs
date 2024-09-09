using System;
using System.Collections.Generic;
using System.Text;
using MVCClassRoster;

namespace MVCClassRoster
{
    class Student : Person
    {
        private string classRank;

        public Student() : base()
        {
            classRank = "";
        } //Student constructor

        public Student(string newFirstName, string newLastName, string newClassRank) : base(newFirstName, newLastName)
        {
            classRank = newClassRank;
        } // Student constructor with 3 params, using base constructor from Person to get newFirstName and newLastName params

        public string ClassRank
        {
            get { return classRank; }
            set { classRank = value; }
        } // ClassRank prop

        public override string ToString()
        {
            return string.Format("First Name:{0}, Last Name:{1}, ClassRank:{2}", FirstName, LastName, ClassRank);
        } // overriding ToString for Student

    } // Student class inheriting from Person
} // MVCClassRoster namespace