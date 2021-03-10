using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{

    [TestClass]
    public class Switch
    {
        enum Weekday { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
        [TestMethod]
        public void SwitchCases()
        {
            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("This is a default. It will execute if no case is met.");
                    break;

            }

            Weekday today = Weekday.Wednesday;
            switch (today)
            {
                case Weekday.Monday:
                case Weekday.Tuesday:
                case Weekday.Wednesday:
                case Weekday.Thursday:
                case Weekday.Friday:
                    Console.WriteLine("Hope you are ready to work");
                    break;
                case Weekday.Saturday:
                case Weekday.Sunday:
                    Console.WriteLine("Sorry, we are closed.");
                    break;

            }
            int age = 37;
            switch (age)
            {
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                case 22:
                case 23:
                    break;
                default:
                    break;
            }

        }

        [TestMethod]
        public void SwitchExpressions()
        {
            string output;
            int action = 1;

            switch (action)
            {
                case 0:
                    output = "Case 0";
                    break;
                case 1:
                    output = "Case 1";
                    break;
                case 2:
                    output = "Case 2";
                    break;
                default:
                    output = "Default Case";
                    break;
            }

            Console.WriteLine(output);

        }

    }
}
