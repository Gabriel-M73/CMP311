using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoster
{
    class Instructor : Person
    {
        private string contactInfo;

        public Instructor() : base()
        {
            contactInfo = "";
        } // Instructor constructor

        public Instructor(string newFirstName,  string newLastName, string newContactInfo) : base(newFirstName, newLastName)
        {
            contactInfo = newContactInfo;
        } // Instructor constructor with 3 params, using base constructor from Person to get newFirstName and newLastName params

        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        } // ContactInfo prop

        public override string ToString()
        {
            return string.Format("First Name:{0}, Last Name:{1}, Contact Info:{2}", FirstName, LastName, ContactInfo);
        } // overriding ToString for Instructor

    } // Instructor class
} // ClassRoster namespace