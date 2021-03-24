using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morning_Challenge_W1D3
{
    [TestClass]
    public class Calculator
    {
        public double NumOne { get; set; }
        public double NumTwo { get; set; }

        public Calculator() { }

        public Calculator(double numOne, double numTwo)
        {
            NumOne = numOne;
            NumTwo = numTwo;
        }

        public double Addition(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }

        public double Subtract(double numOne, double numTwo)
        {
            double difference = numOne - numTwo;
            return difference;
        }
        public double Multiply(double numOne, double numTwo)
        {
            double product = numOne * numTwo;
            return product;
        }

        public double Divide(double numOne, double numTwo)
        {
            double quotient = numOne / numTwo;
            return quotient;
        }

        int numOne = 27;
        int numTwo = 3;

        public void AddTest()
        {
            Calculator calculate = new Calculator();

            double sum = calculate.Addition(numOne, numTwo);
            Console.WriteLine(sum);
        }
    

        public void SubTest()

        {
            Calculator calculate = new Calculator();

            double difference = calculate.Subtract(numOne, numTwo);
            Console.WriteLine(difference);
        }

        public void ProductTest()
        {
            Calculator calculate = new Calculator();

            double product = calculate.Multiply(2, 4);
            Console.WriteLine(product);
        }
        public void QuotientTest()
        {
            Calculator calculate = new Calculator();

            double quotient = calculate.Divide(6, 2);
            Console.WriteLine(quotient);
        }
    }

   


}
