using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ValueTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;
            isDeclared = true;

            bool isDeclaredAndInitialized = false;

            isDeclaredAndInitialized = true;

        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte sByteExample = 127;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = 2147483647;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775807;

            int a = 15;
            int b = -15;

            byte age = 25;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f;
            double doubleExample = 1.789053278907036d;
            decimal decimalExample = 1.2578907289045789789789789787897m;


            Console.WriteLine(1.2578907289045789789789789787897f);
            Console.WriteLine(1.2578907289045789789789789787897d);
            Console.WriteLine(1.2578907289045789789789789787897m);


        }

        enum PastryType { Cake, Cupcake, Eclaire, Petitfour, Croissant }
        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Croissant;
            PastryType anotherOne = PastryType.Cake;
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;

            DateTime birthday = new DateTime(1800, 6, 20);
        }

    }

}
