using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.AdapterSpace
{
    public class Sparrow : IBird
    {
        public void fly()
        {
            Console.WriteLine("..Flying..");
        }

        public void makeSound()
        {
            Console.WriteLine("..Chirp Chirp..");
        }
    }
    public class PlasticToyDuck : IToyDuck
    {
        public void squeak()
        {
            Console.WriteLine("..Squeak..");
        }
    }

    // When we want a toyDuck to makeSound
    public class BirdAdapter : IToyDuck
    {
        private IBird _bird;
        public BirdAdapter(IBird bird)
        {
            _bird = bird;
        }
        public void squeak()
        {
            _bird.makeSound();
        }
    }
}
