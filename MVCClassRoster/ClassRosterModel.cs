using System;
using System.Collections.Generic;
using System.Text;
using MVCClassRoster;

namespace MVCClassRoster
{
    class ClassRosterModel
    {
        Instructor myInstructor;
        List<Student> studentRoster;

        public ClassRosterModel()
        {
            myInstructor = new Instructor();
            studentRoster = new List<Student>();
        } // ClassRosterModel ctor for instructor and studentRoster

        public void addInstructor(string firstName, string lastName, string contactInfo)
        {
            myInstructor.FirstName = firstName;
            myInstructor.LastName = lastName;
            myInstructor.ContactInfo = contactInfo;
        } // addInstructor method

        public void addStudent(string firstName, string lastName, string classRank)
        {
            Student myStudent = new Student();
            myStudent.FirstName = firstName;
            myStudent.LastName = lastName;
            myStudent.ClassRank = classRank;
            studentRoster.Add(myStudent);
        } // addStudent method

        public Instructor getInstructor()
        {
            return myInstructor;
        } // getInstructor

        public List<Student> getStudentRoster()
        {
            return studentRoster;
        } // getStudentRoster
    } // ClassRosterModel class
} // MVCClassRoster namespace