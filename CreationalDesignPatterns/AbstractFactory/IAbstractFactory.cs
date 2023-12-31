using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.AbstractFactorySpace
{
    public interface ITable
    {
        void Assemble();
    }
    public interface IChair
    {
        void Assemble();
    }
    public interface IFurnitureFactory
    {
        ITable getTable();
        IChair getChair();
    }
}
