﻿using System.Threading.Channels;

namespace DrFrahkensteen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = null;
            string userArms = null;
            string userLegs = null;
            string userBody = null;
            string userBrain = null;
            int calculatedStrength = 0;
            int calculatedDexterity = 0;
            int calculatedStamina = 0;
            int calculatedHealth = 0;
            int calculatedIntelligence = 0;

            Console.Title = "Dr. Frahkensteen";

            Console.WriteLine("Welcome Dr. Frahkensteen! I am \"I\"gor and I am here to assist you in creating your very own MONSTER!!!!");
            do
            {
                int partInput = MonsterCreationInterface();
                switch (partInput)
                {
                    case 1:
                        userName = MonsterNaming();
                        break;
                    case 2:
                        userArms = MonsterArmsChoice();
                        break;
                    case 3:
                        userLegs = MonsterLegsChoice();
                        break;
                    case 4:
                        userBody = MonsterBodyChoice();
                        break;
                    case 5:
                        userBrain = MonsterBrainChoice();
                        break;
                    default:
                        break;
                }
                Console.Clear();
                if (userName == null || userArms == null || userLegs == null || userBody == null || userBrain == null)
                {
                    Console.WriteLine("There are still some parts of your monster that are missing.\n\n");
                }

            }
            while (userName == null || userArms == null || userLegs == null || userBody == null || userBrain == null);

            Console.Clear();
            Console.WriteLine("I think it is working...");
            Console.WriteLine("Something is happening...");
            Console.WriteLine("Flip...the...switches!!!!");
            Console.WriteLine("IT'S ALIVE!");




            //TODO if all Monster(values) have something other than a null value create the Monster Object.

            //TODO create an interface to use Monster Class Methods - "Display, play and enhance monster"


            Monster userMonster = new Monster(userName, userArms, userLegs, userBody, userBrain, calculatedStrength, calculatedDexterity, calculatedStamina, calculatedHealth, calculatedIntelligence);

        }
        //TODO Monster Creation Interface

        static int MonsterCreationInterface()
        {
            int userChoice;
            Console.WriteLine("What would you like to add to your monster?");
            Console.WriteLine("1. Name\n2. Arms\n3. Legs\n4. Body\n5. Brain");
            Console.Write("Please make your selection: ");
            return userChoice = Convert.ToInt32(Console.ReadLine());

            // TODO swith-case calling on other value setting methods for monster creation

        }


        //TODO Methods for generating data to be stored in Monster
        //TODO Naming Method
        static string MonsterNaming()
        {
            Console.Clear();
            Console.Write("Please write a name to call your monster: ");
            return Console.ReadLine();
        }
        //TODO Arms Method
        static string MonsterArmsChoice()
        {
            Console.Clear();
            Console.WriteLine("Master...What arms should I find for our monster? \n1. The arms of a swimmer\n2. The arms of a bodybuilder\n3. The arms of a musician\n");
            Console.Write("Please make your choice: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    return "swimmer";
                case 2:
                    return "bodybuilder";
                case 3:
                    return "musician";
                default:
                    return null;
            }
        }
        //TODO Legs Method
        static string MonsterLegsChoice()
        {
            Console.Clear();
            Console.WriteLine("Master...What legs should I find for our monster? \n1. The legs of a laborer\n2. The legs of a triathlete\n3. The arms of a swordfighter\n");
            Console.Write("Please make your choice: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    return "laborer";
                case 2:
                    return "triathlete";
                case 3:
                    return "swordfighter";
                default:
                    return null;
            }
        }
        //TODO Body Method
        static string MonsterBodyChoice()
        {
            Console.Clear();
            Console.WriteLine("Sir, we are making progress...What body should I find for our monster? \n1. The body of a your average man\n2. The body of a short man\n3. The body of a tall man\n");
            Console.Write("Please make your choice: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    return "average man";
                case 2:
                    return "short man";
                case 3:
                    return "tall man";
                default:
                    return null;
            }
        }

        //TODO Brain Method
        static string MonsterBrainChoice()
        {
            Console.Clear();
            Console.WriteLine("Master!!! A most important choice lies in front of you.\nFrom whom should I select the brain for our monster? \n1. A Genius\n2. A Normal Man\n3. \"Abbie\"-someone \n");
            Console.Write("Please make your choice: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    return "genius";
                case 2:
                    return "average";
                case 3:
                    return "abnormal";
                default:
                    return null;
            }
        }
        //TODO arithmatic Method for Strength
        //TODO arithmatic Method for Dexterity
        //TODO arithmatic Method for Stamina
        //TODO arithmatic Method for Health
        //TODO arithmatic Method for Intelligence
    }
        
}