using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Outlaw arthurMorgan = new Outlaw(15000, "Arthur Morgan", "Double-Action Revolver", "Wild West");
            arthurMorgan.Intro();

            Outlaw johnMarston = new Outlaw(10000, "John Marston", "Mauser Pistol", "Wild West");
            johnMarston.Intro();

            Outlaw dutchVanDerLinde = new Outlaw(5000, "Dutch van der Linde", "Schofield Revolver", "Tahiti");
            dutchVanDerLinde.Intro();
        }
    }

    public abstract class Person
    {
        public string Name { get; set; }
        protected string Occupation { get; set; }
        public abstract void Intro();
    }

    public class Outlaw : Person
    {
        public string Weapon { get; set; }
        public int Bounty { get; set; }
        private string Territory { get; set; }

        public Outlaw(int bounty, string name, string weapon, string territory)
        {
            Bounty = bounty;
            Name = name;
            Weapon = weapon;
            Territory = territory;
            Occupation = "Outlaw";
        }

        public override void Intro()
        {
            Console.WriteLine($"Outlaw {Name} - {Weapon} - Bounty: ${Bounty}, Territory: {Territory}");
        }
    }
}