using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.AdapterSpace
{
    public interface IBird
    {
        void fly();
        void makeSound();
    }
    public interface IToyDuck
    {
        void squeak();
    }
}
