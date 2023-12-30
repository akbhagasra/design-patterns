using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.SingletonSpace
{
    public class Singleton
    {
        private static Singleton _instance;
        private Singleton() 
        {
            Console.WriteLine("Singleton object initialized");
        }

        public static Singleton getInstance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
