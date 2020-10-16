using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
        public Address Address { get; set; }
        public Student()
        {
            FirstName = "";
            LastName = "";
            Major = "";
            GPA = 0;
            Address = new Address();
        }
        public Student(string firstName, string lastName, string major, double gpa)
        {
            Address = new Address();
            FirstName = firstName;
            LastName = lastName;
            Major = major;
            GPA = gpa;
            
        }
        public string CalculateDistinction()
        {
            string Distinction = "";
            if (GPA > 3.399999999 && GPA < 3.6)
            {
                Distinction = "Cum Laude";
            }
            else if (GPA > 3.5999999 && GPA < 3.8)
            {
                Distinction = "Magna Cum Laude";
            }
            else if (GPA > 3.8)
            {
                Distinction = "Summa Cum Laude";
            }
            else
            {
                Distinction = "No Distinction";
            }
            return Distinction;
        }
        public void SetAddress(int streetNumber, string streetName, string state, string city, int zipcode)
        {
            Address.StreetNumber = streetNumber;
            Address.StreetName = streetName;
            Address.State = state;
            Address.City = city;
            Address.Zipcode = zipcode;
            

        }
        public override string ToString()
        {
            string Message = $"{FirstName}, {LastName}, {Major}, {CalculateDistinction()}";
            return Message;
        }


    }
}
