using CreationalDesignPatterns.AbstractFactorySpace;
using CreationalDesignPatterns.FactorySpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    public class AbstractFactoryProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory demo started");
            Console.WriteLine();

            IFurnitureFactory wFactory = new WoodenFactory();
            IFurnitureFactory mFactory = new MetalFactory();

            // Metal chair
            IChair mChair = mFactory.getChair();
            mChair.Assemble();

            // Wooden Table
            ITable wTable = wFactory.getTable();
            wTable.Assemble();

            // Metal Table
            ITable mTable = mFactory.getTable();
            mTable.Assemble();

            // Wooden chair
            IChair wChair = wFactory.getChair();
            wChair.Assemble();

            Console.WriteLine();
            Console.WriteLine("Abstract Factory demo ended");
            Console.WriteLine(wChair.ToString());
            Console.ReadKey();
        }
    }
}
