using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class User
    {


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; }
        public DateTime DateOfBirth { get; set; }

        //method for full name
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }


        //method for age in years
        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfAge;
            }
        }

        //blank constructor
        public User() { }

        //constructor
        public User(string firstName,string lastName,int identityNumber, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = identityNumber;
            DateOfBirth = dateOfBirth;
        }

    }
}
