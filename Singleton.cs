using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    
    sealed class Singleton
    {
        private static int counter = 0;

        //Not needed for EAGER Loading
        //private static readonly object lockObj = new object();
        
        // Do this for LAZY initialization
        //private static Singleton instance = null;

        // Do this for LAZY Loading with Lazy<> keyword. Available .Net 4.0 and later
        private static readonly Lazy<Singleton> lazyInstance = new Lazy<Singleton>(()=> new Singleton());

        // EAGER Loaging
        //private static readonly Singleton eagerInstance = new Singleton();

        public static Singleton GetInstance
        {
            get
            {
                // Create an object only the first time 

                // The object creation is delayed. It will not happen until this property is called. 
                // This late initialization is also called - LAZY INITIALIZATION (usually okay with single threaded applications)
                //if (instance == null)
                //{
                //    lock (lockObj)
                //    {
                //        if (instance == null)
                //        {
                //            instance = new Singleton();
                //        }
                //    }
                //}

                //return eagerInstance;
                return lazyInstance.Value;
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
