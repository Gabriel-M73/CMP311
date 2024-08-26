using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoster
{
    class Person
    {
        private string firstName;
        private string lastName;

        public Person()
        {
            firstName = "";
            lastName = "";
        } // Person constructor

        public Person(string newFirstName, string newLastName)
        {
            firstName = newFirstName;
            lastName = newLastName;
        } // Person constructor w/ 2 params

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        } // FirstName property

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        } // LastName property

    } // Person class

} // ClassRoster namespace