using ArenaGame;
using System;
using WeaponsLibrary;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of battles:");
            int rounds = Int32.Parse(Console.ReadLine());
            int oneWins = 0, twoWins = 0;

            for (int i = 0; i < rounds; i++)
            {
                Weapon one = new Excalibur("Excalibur");
                Weapon two = new Sai("Sai");
                Weapon three = new Katana("Katana");
                Weapon four = new RecurveBow("RecurveBow");

                Hero[] allHeroes = {
                    new Knight("Sir Lancelot", one),
                    new Rogue("Robin Hood", two),
                    new Samurai("Ōishi Yoshio", three),
                    new Archer("Katniss Everdeen", four)
                };

                Hero heroOne = allHeroes[Random.Shared.Next(allHeroes.Length)];
                Hero heroTwo;

                do
                {
                    heroTwo = allHeroes[Random.Shared.Next(allHeroes.Length)];
                } 
                while (heroTwo == heroOne);

                Console.WriteLine($"Arena fight between: {heroOne.Name} with {heroOne.Weapon.Name} and {heroTwo.Name} with {heroTwo.Weapon.Name}");

                Arena arena = new Arena(heroOne, heroTwo);
                Hero winner = arena.Battle();
                Console.WriteLine($"Winner is: {winner.Name}");
                if (winner == heroOne) oneWins++; else twoWins++;

            }
            

            Console.ReadLine();
        }
    }
}
