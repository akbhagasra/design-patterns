using StructuralDesignPatterns.AdapterSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns
{
    internal class AdapterProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter demo started");
            Console.WriteLine();

            IBird bird = new Sparrow();
            bird.fly();
            bird.makeSound();
            Console.WriteLine();

            IToyDuck toy = new PlasticToyDuck();
            toy.squeak();
            Console.WriteLine();

            // Creating a toy which can make sound "Chirp Chirp"
            IToyDuck adaptedToy = new BirdAdapter(bird);
            Console.WriteLine("A toy duck making sound chirp chirp on squeak()");
            adaptedToy.squeak();

            // Here target interface is IToyDuck which is implemented by adapter.
            Console.WriteLine();
            Console.WriteLine("Adapter demo ended");
            Console.ReadKey();
        }
    }
}
