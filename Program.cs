using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singletonEmp = Singleton.GetInstance;
            singletonEmp.PrintDetails("This is the first message for employees...");

            Singleton singletonContract = Singleton.GetInstance;
            singletonContract.PrintDetails("Sending a message for Contractors ...");

            Singleton.DerivedSingleton derived = new Singleton.DerivedSingleton();
            derived.PrintDetails("Is this a hack? ");

            Console.ReadLine();

        }
    }
}
