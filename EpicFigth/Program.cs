using System;

namespace EpicFigth
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero, villain;
            string heroweapon, villainweapon;
            heroweapon = RandomWeapon();
            hero = RandomHero();
            villain = RandomVillain();
            villainweapon = RandomWeapon();
            Console.WriteLine($"Random hero: {hero} ");
            Console.WriteLine($"Random villain: {villain} ");
            Console.WriteLine($"{villain} will figth with {villainweapon}.");
            Console.WriteLine($"{hero} will figth with {heroweapon}");
        }

        private static int RandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, someArray.Length);

            return RandomIndex;
        }

        private static string RandomHero()
        {
            string[] heros = { "Batman", "Spongebob", "Spiderman", "Patric" };

            return heros[RandomIndex(heros)];

        }

        private static string RandomVillain()
        {
            string[] villains = { "Pepa Pig", "Mirjam", "Sirley" };
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, villains.Length);

            string randomVillain = villains[RandomIndex];
            return randomVillain;

        }

        private static string RandomWeapon()
        {
            string[] weapon = { " axe", "sword", "pistol" };

            return weapon[RandomIndex(weapon)];
        }

    }
}
