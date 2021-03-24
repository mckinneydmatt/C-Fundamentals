using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MorningChallengeW2D3
{
    [TestClass]
    public class Customer
    {
        public int IDNumber { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int YearsUsing { get; set; }

        public Customer() { } //required empty

 
        public Customer(int idNumber, string lastName, int age, DateTime enrollmentDate, int yearsUsing)
            
        {
            IDNumber = idNumber;
            LastName = lastName;
            Age = age;
            EnrollmentDate = enrollmentDate;
            YearsUsing = yearsUsing;
        }
    }
}
