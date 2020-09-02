using System;
using System.Collections.Generic;
using System.Text;

namespace StudentUMLExample
{
    class Student
    {
        public int SoonerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsONProbation { get; set; }
        public double GPA { get; set; }
        private double BursarBalance { get; set; }
        public Student ()
        {
            SoonerID = -1;
            FirstName = "";
            LastName = "";
            IsONProbation = false;
            GPA = 0;
            BursarBalance = 1000;
        }
        public Student(int ID, string FName, string LName, double BursarBalance)
        {
            SoonerID = ID;
            FirstName = FName;
            LastName = LName;
            IsONProbation = false;
            GPA = 0;
            this.BursarBalance = BursarBalance;
        }

        public void MakePayment (double Amount)
        {
            if (Amount > 0)
            {
                BursarBalance = BursarBalance - Amount;
                //BursarBalance -= Amount;
            }
            else
            {
                throw new Exception();
            }
        }
        public double CheckBalance ()
        {
            return BursarBalance;
        }

        public override string ToString()
        {
            string Output = $"{FirstName} {LastName} {SoonerID}";
            if (IsONProbation = true)
            {
                Output += " is on probation. \n";
            }
            else
            {
                Output += " is not on probation. \n";
            }
            Output += $"They have a {GPA.ToString("N2")} GPA and they owe {BursarBalance.ToString("C2")}";           
            return base.ToString();
        }



    }
}
