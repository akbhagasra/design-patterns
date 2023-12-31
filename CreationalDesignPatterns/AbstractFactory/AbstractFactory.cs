using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.AbstractFactorySpace
{
    public class WoodenTable: ITable
    {
        public void Assemble()
        {
            Console.WriteLine("Assembling wooden table");
        }
    }
    public class MetalTable : ITable
    {
        public void Assemble()
        {
            Console.WriteLine("Assembling metal table");
        }
    }
    public class WoodenChair : IChair
    {
        public void Assemble()
        {
            Console.WriteLine("Assembling wooden chair");
        }
    }
    public class MetalChair : IChair
    {
        public void Assemble()
        {
            Console.WriteLine("Assembling metal chair");
        }
    }
    public class WoodenFactory : IFurnitureFactory
    {
        public IChair getChair()
        {
            return new WoodenChair();
        }

        public ITable getTable()
        {
            return new WoodenTable(); 
        }
    }
    public class MetalFactory : IFurnitureFactory
    {
        public IChair getChair()
        {
            return new MetalChair();
        }

        public ITable getTable()
        {
            return new MetalTable();
        }
    }
}
