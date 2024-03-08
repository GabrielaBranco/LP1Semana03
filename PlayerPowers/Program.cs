using System;

namespace PlayerPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number:");
            string input = Console.ReadLine();

            int n = int.Parse(input);

            string[] myPowers = {Powers.Fly.ToString(), Powers.SuperStrength.ToString(), Powers.XRayVision.ToString()};

            
        }
    }
}
