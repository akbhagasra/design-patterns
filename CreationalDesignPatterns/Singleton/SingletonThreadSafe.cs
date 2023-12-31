using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.SingletonSpace
{
    public class SingletonThreadSafe
    {
        private static SingletonThreadSafe _safeInstance = new SingletonThreadSafe();
        private SingletonThreadSafe()
        {
            Console.WriteLine("SingletonThreadSafe object initialized");
        }

        public static SingletonThreadSafe getSafeInstance()
        {
            if (_safeInstance == null)
            {
                _safeInstance = new SingletonThreadSafe();
            }
            return _safeInstance;
        }
    }

    public class SingletonThreadSafeLazy
    {
        private static SingletonThreadSafeLazy _instance = new SingletonThreadSafeLazy();
        private SingletonThreadSafeLazy()
        {
            Console.WriteLine("SingletonThreadSafeLazy object initialized");
        }

        public static SingletonThreadSafeLazy getSafeInstance()
        {
            return _instance;
        }
    }
}
