using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    //this is our contract
    //anything that implements Ifruit must adhere to the contract - must do all of its methods and have all its properties
    public interface IFruit
    {
        string Name { get; }
        bool IsPeeled { get; set; }
        string Peel();
    }

    public interface IOrange : IFruit
    {
        string Squeeze();
    }
}
