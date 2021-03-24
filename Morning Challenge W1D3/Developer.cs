using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Morning_Challenges
{

    [TestClass]

    public class Developer
    {
        public string LastName { get; set; }
        public int Identifier { get; set; }
        public bool HasPluralsight { get; set; }


        public Developer() { } //required empty
  
        public Developer(string lastName, int identifier, bool hasPluralsight)
        {
            LastName = lastName;
            Identifier = identifier;
            HasPluralsight = hasPluralsight;

        }

    }

}


