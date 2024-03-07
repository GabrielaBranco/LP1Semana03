using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, give me a string!");
            string stringInput = Console.ReadLine();

            Console.WriteLine("Now give me a character!");
            char character = Console.ReadLine()[0];

            string finalString = "";
            for (int i = 0; i < stringInput.Length; i++)
            {
                if (stringInput[i] == character)
                {
                    finalString += "X";
                }
                else
                {
                    finalString += stringInput[i];
                }
            }

            Console.WriteLine(finalString);
        }
    }
}
