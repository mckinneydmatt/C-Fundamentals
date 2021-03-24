using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class IFruitTests
    {

        [TestMethod]
        public void CallingInterfaceMethods()
        {
            //-not using this -> Banana banana = new Banana();
            IFruit banana = new Banana();

            string output = banana.Peel();
            Console.WriteLine(output);


            Console.WriteLine("The banana is peeled" + banana.IsPeeled);

            IFruit grape = new Grape();
            string output2 = grape.Peel();
            Console.WriteLine(output2);

            Console.WriteLine("The grape is peeled?:" + grape.IsPeeled);


            //Assert.IsTrue(banana.IsPeeled);
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void InterfacesInCollections()
        {
            IFruit orange = new Orange();

            List<IFruit> FruitSalad = new List<IFruit>();

            {
                new Banana();
                new Grape();
            };

            FruitSalad.Add(orange);

            foreach (IFruit fruit in FruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());
                Assert.IsInstanceOfType(fruit, typeof(IFruit));

                if (fruit is IOrange orange1)
                {
                    Console.WriteLine(orange1.Squeeze());
                }
            }
        }

        //helper method
        private string GetFruitName(IFruit fruit)
        {
            return $"This fruit is called {fruit.Name}.";
        }

        [TestMethod]
        public void InterfacesInMethods()
        {
            //we are going to use a class that implements IFruit
            Grape grape = new Grape();

            string output = GetFruitName(grape);

            Console.WriteLine(output);

            Assert.IsTrue(output.Contains("This fruit is called grape."));
        }

        [TestMethod]
        public void TypeOfInstance()
        {
            List<IFruit> fruitSalad = new List<IFruit>
            {
                new Orange(true),
                new Orange(),
                new Grape(),
                new Orange(),
                new Banana(true),
                new Grape()
            };

            Console.WriteLine("Is the orange peeled?");

            foreach (IFruit fruit in fruitSalad)
            {
                //this is called pattern matching
                if (fruit is Orange orange)
                {
                    if (orange.IsPeeled)
                    {
                        Console.WriteLine("Is a peeled orange");
                        orange.Squeeze();
                    }
                    else
                    {
                        Console.WriteLine("It is an orange, but not peeled.");
                    }
                }
                else if (fruit.GetType() == typeof(Grape))
                {
                    Console.WriteLine("Is a grape.");
                }
                else if (fruit.IsPeeled)
                {
                    Console.WriteLine("is a peeled banana");
                }
                else
                {
                    Console.WriteLine("is a banana");
                }

            }

        }


    }
}
