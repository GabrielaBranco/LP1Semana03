using System;

namespace FamousQuotes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("You talking to me?");//Taxi driver?
            MyPrecious();
            Console.WriteLine("Dodge this");//Matrix
            Hasta();
        }

        private static void Hasta()
        {
            TheMoney();
            Console.WriteLine("Hasta la vista, baby.");//The Terminator
            MyPrecious();
        }

        private static void TheMoney()
        {
            Console.WriteLine("Show me the money!");//no idea!
        }

        private static void MyPrecious()
        {
            TheMoney();
            Console.WriteLine("My precious.");//LOTR
        }
    }
}
