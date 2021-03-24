using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = true;
            if (userIsHungry)
            {
                Console.WriteLine("Eat Something");
            }

            int hoursSpentStudying = 1;
            if (hoursSpentStudying < 16)
            {
                Console.WriteLine("Are you even trying");
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = false;
            if (choresAreDone)
            {
                Console.WriteLine("Have fun at the movies!");
            }
            else
            {
                Console.WriteLine("You must stay home and finish your chores!");
            }

            string input = "7";
            int totalHours = int.Parse(input);

            if (totalHours >= 8)
            {
                Console.WriteLine("You should be well rested.");
            }
            else
            {
                Console.WriteLine("You might be tired today.");
                if (totalHours < 4)
                {
                    Console.WriteLine("You should get more sleep.");
                }
            }

            int age = 22;
            if (age > 17)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                if (age > 6)
                {
                    Console.WriteLine("You are a kid.");
                }
                else if (age > 0)
                {
                    Console.WriteLine("You are far too young to be on a computer.");
                }
                else
                {
                    Console.WriteLine("You are not born yet.");
                }
            }

            if (age < 65 && age > 18)
            {
                Console.WriteLine("Age is between 18 and 65");
            }

            if (age > 65 || age < 18)
            {
                Console.WriteLine("Age is either greater than 65 or less than 18");
            }

            if (age == 21)
            {
                Console.WriteLine("Age is equal to 21.");
            }

            if (age != 36)
            {
                Console.WriteLine("Age is not equal to 36.");
            }
        }
    }
}
