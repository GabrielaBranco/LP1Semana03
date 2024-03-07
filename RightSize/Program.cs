using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = args;

            foreach (string word in words)
            {
                if(word.Length > 6)
                {
                    break;
                }
                if (word.Length > 3)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
