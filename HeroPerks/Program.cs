using System;

namespace HeroPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks myPerks = Perks.WaterBreathing | Perks.Stealth | Perks.AutoHeal | Perks.DoubleJump;

            string[] letters = args;
            
            //Deactivates all perks
            myPerks ^= Perks.WaterBreathing;
            myPerks ^= Perks.Stealth;
            myPerks ^= Perks.AutoHeal;
            myPerks ^= Perks.DoubleJump;

            if (letters.Length == 0)
            {
                Console.WriteLine("No perks at all!");
                return;
            }

            //Separates the argument into characters 
            for (int i = 0; i < letters.Length; i++)
            {
                foreach (char character in letters[i])
                {
                    if (character == 'w')
                    {
                        myPerks ^= Perks.WaterBreathing;
                    }
                    else if (character == 's')
                    {
                        myPerks ^= Perks.Stealth;
                    }
                    else if (character == 'a')
                    {
                        myPerks ^= Perks.AutoHeal;
                    }
                    else if (character == 'd')
                    {
                        myPerks ^= Perks.DoubleJump;
                    }
                    else
                    {
                        Console.WriteLine("Unknown Perk!");
                        return;
                    }
                }
            }

            Console.WriteLine(myPerks);

            if (( myPerks & Perks.AutoHeal ) != Perks.AutoHeal)
            {
                Console.WriteLine("Not Gonna Make It!");
            }
            if (( myPerks & (Perks.Stealth | Perks.DoubleJump)) == (Perks.Stealth | Perks.DoubleJump))
            {
                Console.WriteLine("Silent jumper!");
            }
        }
    }
}
