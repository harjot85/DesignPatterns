using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    
    class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                //Create an object only the first time 
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        //A private constructor ensures object construction happens inside the class only
        private Singleton()
        {
            Console.WriteLine(++counter);
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        public class DerivedSingleton : Singleton
        {

        }
    }
}
