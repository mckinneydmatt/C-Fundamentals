using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Arithmetic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 15;

            //addition
            int sum = a + b;

            //this is shorthand additon
            sum += 3;
            Console.WriteLine(sum);

            //subtraction
            int difference = a - b;
            //difference-=3;
            Console.WriteLine($"difference: {difference}");

            //multiplication
            int product = a * b;
            Console.WriteLine($"product: {product}");

            //division
            int quotient = a / b;
            Console.WriteLine($"quotient: {quotient}");

            //modulous
            int remainder = a % b;
            Console.WriteLine($"remainder: {quotient}");

            DateTime now = DateTime.Now;
            DateTime someday = new DateTime(1992, 9, 16);

            TimeSpan timeSpan = now - someday;

            Console.WriteLine(timeSpan);
            Console.WriteLine(timeSpan.Days);
            Console.WriteLine(timeSpan.TotalMilliseconds);

        }
    }
}
