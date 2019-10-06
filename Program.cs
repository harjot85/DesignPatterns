using System;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CallSingleton();



            Console.ReadLine();
        }

        static void CallSingleton()
        {
            //Proves paralled invoking of two methods can violate principle of Singleton as both threads may initialize the object at the same time.
            Parallel.Invoke(
                () => PrintContractorDetails(), 
                () => PrintEmployeeDetails()
            );

            //SINGLETON: Prove that the object can be recreated with a derived class
            //Singleton.DerivedSingleton derived = new Singleton.DerivedSingleton();
            //derived.PrintDetails("Is this a hack? ");
        }

        private static void PrintContractorDetails() 
        {
            Singleton singletonContract = Singleton.GetInstance;
            singletonContract.PrintDetails("Sending a message for Contractors ...");
        }

        private static void PrintEmployeeDetails()
        {
            Singleton singletonEmp = Singleton.GetInstance;
            singletonEmp.PrintDetails("This is the first message for employees...");
        }
    }
}
