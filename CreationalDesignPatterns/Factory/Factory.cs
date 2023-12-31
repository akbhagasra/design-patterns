using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.FactorySpace
{
    public class Suv: ICarItem
    {
        public void Assemble()
        {
            Console.WriteLine("Assembling a SUV");
        }
    }
    public class Sedan : ICarItem
    {
        public void Assemble()
        {
            Console.WriteLine("Assembling a Sedan");
        }
    }
    public class Hatchback : ICarItem
    {
        public void Assemble()
        {
            Console.WriteLine("Assembling a Hatchback");
        }
    }
    public class Factory
    {
        public static ICarItem getCar(string type)
        {
            switch (type)
            {
                case "sedan":
                    return new Sedan();
                case "suv":
                    return new Suv();
                case "hatchback":
                    return new Hatchback();
            }
            return null;
        }
    }
}
