using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Morning_Challenge_W1D3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Poppins()
        {
            string poppins = "Supercalifragilisticexpialidocious";

            foreach (char letter in poppins)
            {
                Console.WriteLine(letter);
            }

        }

        [TestMethod]
        public void poppinsWithI()
        {
            string poppins = "Supercalifragilisticexpialidocious";
            foreach (char letter in poppins)
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an I");
                }

        }

        [TestMethod]
        public void bonusOne()
        {
            string poppins = "Supercalifragilisticexpialidocious";

            Console.WriteLine($"The number of letters in Supercalifragilisticexpialidocious is {poppins.Length}");
        }

        [TestMethod]
        public void bonusTwo()
        {
            string poppins = "Supercalifragilisticexpialidocious";
            foreach (char letter in poppins)
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }

                else if (letter == 'l')
                {
                    Console.WriteLine(letter);
                }

                else
                {
                    Console.WriteLine("Not an I or L");
                }

        }

    }
}
