using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DrFrahkensteen
{
    public class Monster
    {
        //fields
        private string name;
        private string arms;
        private string legs;
        private string body;
        private string brain;
        private int strength;
        private int dexterity;
        private int stamina;
        private int health;
        private int intelligence;

        //properties
        public string Name { get; set; }
        public string Arms { get; set; }
        public string Legs { get; set; }
        public string Body { get; set; }
        public string Brain { get; set; } 
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Stamina { get; set; }
        public int Health { get; set; }
        public int Intelligence { get; set; }

        //constructor

        public Monster(string name, string arms, string legs, string body, string brain, int strength, int dexterity, int stamina, int health, int intelligence)
        {
            Name = name;
            Arms = arms;
            Legs = legs;
            Body = body;
            Brain = brain;
            Strength = strength;
            Dexterity = dexterity;
            Stamina = stamina;
            Health = health;
            Intelligence = intelligence;
        }

        // -------------------------------------------Methods--------------------------------------------------

        
        public void DisplayMonster()
        {
            Console.WriteLine("=============================================================================================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"                                      {Name.ToUpper()}                                        ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine($"STR: {Strength}                                DEX: {Dexterity}                          INT: {Intelligence} ");
            Console.WriteLine();
            Console.WriteLine($"                    Stamina: {Stamina}                         Health: {Health}                     ");
            Console.WriteLine("=============================================================================================");
        }

        //TODO Sing and Dance method that will decrease Stamina and increase intelligence
        public void SingAndDance()
        {
            //TODO Beep Code of "Puttin' On The Ritz
            Console.Beep(349, 200);
            Console.Beep(415, 200);
            Console.Beep(523, 200);
            Console.Beep(262, 100);
            Console.Beep(349, 200);
            Console.Beep(415, 100);
            Console.Beep(523, 200);
            Console.Beep(262, 200);
            Console.Beep(349, 200);
            Console.Beep(415, 200);
            Console.Beep(523, 200);
            Console.Beep(262, 100);
            Console.Beep(349, 200);
            Console.Beep(415, 100);
            Console.Beep(523, 200);
            Console.Beep(262, 200);
            Console.Beep(330, 200);
            Console.Beep(392, 200);
            Console.Beep(466, 800);
            Thread.Sleep(400);
            Console.Beep(523, 100);
            Console.Beep(466, 50);
            Console.Beep(415, 100);
            Console.Beep(392, 75);
            Console.Beep(349, 800);
            Stamina -= 10;
            
        }
        //TODO Add a more Mini Game experience
        public void Fight()
        {
            Random random = new Random();
            Health -= (random.Next(1, 11));
            
        }
        // Allows a recovery method for the Monster instance - specifically Health and Stamina
        public void RestAndRecover()
        {
            Random random = new Random();
            Health += (random.Next(1, 6));
            Stamina += (random.Next(1, 6));
        }
    }
}
