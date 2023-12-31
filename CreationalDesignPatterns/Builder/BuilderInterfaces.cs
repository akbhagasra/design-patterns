using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.BuilderSpace
{
    public interface IFoodItem
    {
        string name();
        IPacking packing();
        float price();
    }

    public interface IPacking
    {
        string pack();
    }
}
