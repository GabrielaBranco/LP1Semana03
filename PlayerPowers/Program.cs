using System;
using PlayerPowers;

namespace PlayerPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the number of players:");
            string players = Console.ReadLine();

            int n = int.Parse(players);

            Powers[] myPowers = new Powers[n];
            Powers powersList = Powers.Fly | Powers.SuperStrength | Powers.XRayVision;
            

            for(int i = 0; i < myPowers.Length; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Choose your powers player " + (i+1) + "->");
                    Console.WriteLine(powersList);
                    string plyrPowers = Console.ReadLine().ToLower();

                    if(plyrPowers == "fly")
                    {
                        myPowers[i] ^= Powers.Fly;
                    }
                    else if(plyrPowers == "xrayvision")
                    {
                        myPowers[i] ^= Powers.XRayVision;
                    }
                    else if(plyrPowers == "superstrength")
                    {
                        myPowers[i] ^= Powers.SuperStrength;
                    }
                    else if(plyrPowers == "")
                    {
                        Console.WriteLine("No Power!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Unknown Power!");
                        continue;
                    }
                }
                Console.WriteLine("Player " + (i+1) + " powers are: ");
                Console.WriteLine(myPowers[i].ToString());
                Console.WriteLine("");

                if((myPowers[i] & Powers.Fly) == Powers.Fly && ((myPowers[i] & Powers.SuperStrength) == Powers.SuperStrength))
                {
                    Console.WriteLine("Flying Radiation!");
                }
                if((myPowers[i] & Powers.Fly) != Powers.Fly && ((myPowers[i] & Powers.SuperStrength) != Powers.SuperStrength) && ((myPowers[i] & Powers.XRayVision) != Powers.XRayVision))
                {
                    Console.WriteLine("No Powers at all!");
                }
            }
            
        }
    }
}
