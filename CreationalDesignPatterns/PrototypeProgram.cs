using CreationalDesignPatterns.PrototypeSpace;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    internal class PrototypeProgram
    {
        public static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("Prototype demo started");
            Console.WriteLine();

            Prototype obj1 = new Prototype();
            obj1.setId();
            obj1.setData();
            stopWatch.Stop();
            Console.WriteLine($"Obj1 created in {stopWatch.Elapsed.TotalMilliseconds}ms");
            Console.WriteLine(obj1);
            Console.WriteLine();

            // Cloning
            stopWatch.Restart();
            Prototype obj2 = (Prototype)obj1.Clone();
            Prototype obj3 = (Prototype)obj1.Clone();
            stopWatch.Stop();
            Console.WriteLine($"Obj2 & Obj3 created in {stopWatch.Elapsed.TotalMilliseconds}ms");
            Console.WriteLine(obj2);
            Console.WriteLine(obj3);

            Console.WriteLine();
            Console.WriteLine("Prototype demo ended");
            Console.ReadKey();
        }

    }
}
