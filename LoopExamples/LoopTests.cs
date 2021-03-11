using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LoopExamples
{
    [TestClass]
    public class LoopTests
    {
        [TestMethod]
        public void WhileLoops()
        {
            //Just for setup
            int total = 1;

            while (total != 10)
            {
                Console.WriteLine(total);
                total = total + 1;
            }
            total = 0;

            while (true)
            {
                if (total == 10)
                {
                    Console.WriteLine("Goal Reached");
                    break;
                }

                total++;

            }
            Random random = new Random();

            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {
                someCount = random.Next(0, 20);

                if (someCount == 6 || someCount == 10)
                {
                    continue;
                }

                Console.WriteLine(someCount);

                if (someCount == 15)
                {
                    keepLooping = false;
                }
            }

        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 21;

            //initialization, conditional, increment
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Adam", "Justin", "Josh", "Amanda", "Danielle", "Ingeborg" };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Welcome to the class {students[i]}");
            }

        }

        [TestMethod]
        public void ForeachLoops()
        {
            string[] students = { "Adam", "Justin", "Josh", "Amanda", "Danielle", "Ingeborg" };

            foreach (string student in students)
            {
                Console.WriteLine(student + " is a student in the class");
            }

            //string is an array of chars
            string MyName = "Matthew Douglas McKinney";

            foreach (char letter in MyName)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }

        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("hello");
                iterator++;
            } while (iterator < 5);

            do
            {
                Console.WriteLine("My do while condition is false");
            } while (false);

            while (false)
            {
                Console.WriteLine("My while condition is false");
            }
        }

    }
}
