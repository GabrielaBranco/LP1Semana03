using System;

namespace PlayerPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the number of players:");
            string players = Console.ReadLine();

            int n = int.Parse(players);

            string[] myPowers = {Powers.Fly.ToString(), Powers.SuperStrength.ToString(), Powers.XRayVision.ToString()};

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Choose your powers player " + (i+1) + "->");
                for(int j = 0; j < myPowers.Length; j++)
                {
                    Console.WriteLine(j + ". " + myPowers[j]);
                }

                string plyrPowers = Console.ReadLine();

                char[] powers = plyrPowers.ToCharArray();

                Console.WriteLine(powers[0]);

            }
        }
    }
}
