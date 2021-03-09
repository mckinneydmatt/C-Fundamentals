using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ReferenceTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Strings()
        {
            string name;

            string declared;
            declared = "this is initialized.";

            string declareAndInitialize = "this is both declaring and initializing.";

            string firstName = "Matt";
            string lastName = "McKinney";

            string concatenatedFullName = firstName + " " + lastName;

            string interpolationFullName = $"{firstName} {lastName}";

            string compositeFullName = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(interpolationFullName);
            Console.WriteLine(compositeFullName);


        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World";

            string[] stringArray = { "Hello", "World!", "Why", "is it", "always", stringExample };
            string[] somethingEntirelyDifferent = { "some", "word" };

            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);
            somethingEntirelyDifferent[1] = "idk";
            stringArray[0] = "Hey There";
            Console.WriteLine(stringArray[0]);
            Console.WriteLine(somethingEntirelyDifferent[1]);

            List<string> listOfStrings = new List<string>();
            List<int> listOfInts = new List<int>();

            listOfStrings.Add("First string for our list");
            listOfInts.Add(123456);
            
            Console.WriteLine(listOfInts[0]);

            Queue<string> firstInFirstOut = new Queue<string>();

            firstInFirstOut.Enqueue("I'm First");
            firstInFirstOut.Enqueue("I'm Next");

            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);

            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            keyAndValue.Add(7, "Agent");

            string valueSeven = keyAndValue[7];
            Console.WriteLine(valueSeven);

            SortedList<int, string> sortedKetandValue = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();
        }

        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();

            int randomNumber = rng.Next();

            Console.WriteLine(randomNumber);
        }

    }


}
