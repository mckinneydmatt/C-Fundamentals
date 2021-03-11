using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClasses
{
    public class Kitchen : House
    {
        public Kitchen()
        {
            SquareFeetOfHouse = 500;
            Flooring = FloorType.Wood;

        }
        public int NumberofAppliances { get; set; }
        public bool HasAnIsland { get; set; }
        public string GoodPartySpace { get; set; }
    }
}
