﻿using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a string!");
            string stringInput = Console.ReadLine();

            Console.WriteLine("Now give me a character!");
            char character = Console.ReadLine()[0]; //uses only the first character written

            string finalString = "";
            
            for (int i = 0; i < stringInput.Length; i++)
            {
                if (stringInput[i] == character)
                {
                    finalString += "X"; //Pushes X inside final string if the character matches "character"
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
