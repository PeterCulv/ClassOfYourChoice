using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        //TODO Display information (Character Sheet of the created monster)

        //TODO 
    }
}
