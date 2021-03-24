using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class Banana : IFruit
    {
        public string Name
        {
            get
            {
                return "banana";
            }
        }

        public bool IsPeeled { get; set; }

        public Banana()
        {

        }

        public Banana(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        public string Peel()
        {
            IsPeeled = true;
            return $"I peeled a {Name}";
        }

    }

    //we are going to make extra classes here but they should go in their own file.
    //they are classes and they implement ':' an interface
    //IFruit

    public class Orange : IOrange
    {
        public string Name { get { return "Orange"; } }
        public bool IsPeeled { get; set; }

        public Orange()
        {

        }

        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }


        public string Peel()
        {
            IsPeeled = true;
            return "You peeled an orange.";

        }
        public string Squeeze()
        {
            return "You squeezed the orange.....";
        }
    }
    public class Grape : IFruit
    {
        public string Name { get { return "Grape"; } }
        public bool IsPeeled { get; set; }
        public string Peel()
        {
            return "who peels grapes?";
        }

    }
}
