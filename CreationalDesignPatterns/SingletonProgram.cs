using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CreationalDesignPatterns.SingletonSpace;

namespace CreationalDesignPatterns
{
    public class SingletonProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Singleton demo started");
            Console.WriteLine();

            Console.WriteLine("--Thread test Singleton--");
            for(int i = 0; i < 20; i++)
            {
                Thread t = new Thread(() => { var inst = Singleton.getInstance(); });
                t.Start();
            }

            Console.WriteLine("");
            Console.WriteLine("--Thread test SingletonThreadSafe--");
            for (int i = 0; i < 20; i++)
            {
                Thread t = new Thread(() => { var inst = SingletonThreadSafe.getSafeInstance(); });
                t.Start();
            }

            Console.WriteLine("");
            Console.WriteLine("--Thread test SingletonThreadSafeLazy--");
            for (int i = 0; i < 20; i++)
            {
                Thread t = new Thread(() => { var inst = SingletonThreadSafeLazy.getSafeInstance(); });
                t.Start();
            }

            Console.WriteLine();
            Console.WriteLine("Singleton demo ended");
            Console.ReadKey();
        }
    }
}
