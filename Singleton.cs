using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    
    sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                // Create an object only the first time 
                // The object creation is delayed. It will not happen until this property is called. 
                // This late initialization is also called - LAZY INITIALIZATION (usually okay with single threaded applications)
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

        //Create a nested class that derives the Singleton class to prove that it is necessary to have the base class marked as SEALED. 
        //Otherwise the derived class can access the constructor of the base class which will allow multiple object creation of the base class, 
        // and hence will violate the principle of SINGLETON pattern
        //public class DerivedSingleton : Singleton
        //{

        //}
    }
}
