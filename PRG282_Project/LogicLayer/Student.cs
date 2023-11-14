using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.LogicLayer
{
    internal class Student
    {
        public int StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Picture { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; }
        public string Phone { get; set; }
        public string StreetAddress { get; set; }

        public Student () { }

        public Student (int studentNumber, string firstName, string surname, string picture, DateTime dateOfBirth, int gender, string phone, string streetAddress)
        {
            StudentNumber = studentNumber;
            FirstName = firstName;
            Surname = surname;
            Picture = picture;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Phone = phone;
            StreetAddress = streetAddress;
        }
    }
}
