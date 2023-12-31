using CreationalDesignPatterns.FactorySpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    internal class FactoryProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory demo started");
            Console.WriteLine();

            ICarItem suv = Factory.getCar("suv");
            suv.Assemble();
            ICarItem sedan = Factory.getCar("sedan");
            sedan.Assemble();
            ICarItem hatchback = Factory.getCar("hatchback");
            hatchback.Assemble();

            Console.WriteLine();
            Console.WriteLine("Factory demo ended");
            Console.ReadKey();
        }
    }
}
