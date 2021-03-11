using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClasses
{
    public enum HouseType { Cottage, Duplex, Ranch, Mansion }
    public enum FloorType { Wood, Carpet, Tile, Vinyl}
    public class House
    {
        public int NumberOfBedrooms { get; set; }
        public int SquareFeetOfHouse { get; set; }
        public bool DoesItHaveABasement { get; set; }
        public FloorType Flooring { get; set; }
        public HouseType TypeOfHouse { get; set; }

        public House()
        {

        }


    }
}
