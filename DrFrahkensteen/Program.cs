using System.Threading.Channels;

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
            int userCalculatedStrength = 0;
            int userCalculatedDexterity = 0;
            int userCalculatedStamina = 0;
            int userCalculatedHealth = 0;
            int userCalculatedIntelligence = 0;

            Console.Title = "Dr. Frahkensteen";
            // This do-while loop creates a menu system for getting the paramaters for creating the Monster instance
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

                // This if and while condition keep the character creation looping until all choices have a value 
                // and then immediately moves to the instance creation of Class Monster
                if (userName == null || userArms == null || userLegs == null || userBody == null || userBrain == null)
                {
                    Console.WriteLine("There are still some parts of your monster that are missing.\n\n");
                }

            }
            while (userName == null || userArms == null || userLegs == null || userBody == null || userBrain == null);

            //Cinematic sequence for fun (practice in stalling the compiler and lightning effect) 
            Console.Clear();
            Thread.Sleep(500);
            Console.WriteLine("I think it is working...");
            Thread.Sleep(1000);
            LightningFlashes();
            Console.WriteLine("Something is happening...");
            Thread.Sleep(1500);
            LightningFlashes();
            Console.WriteLine("Flip...the...switches!!!!");
            Thread.Sleep(2000);
            LightningFlashes();
            Console.WriteLine("IT'S ALIVE!");
            Thread.Sleep(1500);


            //Taking values from interface creation and assigning scores to certain characteristics of the monster
            userCalculatedStrength = CalculateStrength(userArms, userLegs);
            userCalculatedDexterity = CalculateDexterity(userArms, userLegs);
            userCalculatedStamina = CalculateStamina(userArms, userLegs, userBody);
            userCalculatedHealth = CalculateHealth(userBody);
            userCalculatedIntelligence = CalculateIntelligence(userBrain);
            int userCalculatedHealthMax = userCalculatedHealth;
            int userCalculatedStaminaMax = userCalculatedStamina;
            // Now that all the values have been created - generate Monster with a new instance of Class
            
            Monster userMonster = new Monster(userName, userArms, userLegs, userBody, userBrain, userCalculatedStrength, userCalculatedDexterity, userCalculatedStamina, userCalculatedHealth, userCalculatedIntelligence);
            
            // This is the main playroom for using the generated instance of Monster Class - this is where the Methods of the class are used until the User chooses to end the program
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                userMonster.DisplayMonster();
                Console.WriteLine("What would you like to do with your Monster?");
                Console.WriteLine("1. Sing and Dance\n2. Fight\n3. Rest and Recover\n4. Destroy your monster(End)");
                Console.Write("\nSelect your menu number: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        Console.Clear();
                        //TODO ASCII art feet dancing
                        if (userMonster.Stamina < 10)
                        {
                            Console.WriteLine($"{userMonster.Name} is too tired to perform right now.  You should rest and recover first.");
                        }
                        else
                        {
                            userMonster.SingAndDance();
                            Console.WriteLine("Whew that was exhausting...the monster looks really tired.");
                        }
                        Console.Write("\n\nPress any key to continue...");
                        Console.ReadLine();
                        break;
                    case 2:
                        userMonster.Fight();
                        Console.WriteLine("The townsfolk have risen up against your abomination!!");
                        // If Monster dies program and Monster instance ends.
                        if (userMonster.Health <= 0)
                        {
                            Console.WriteLine($"{userMonster.Name} has been killed.\n\n");
                            isRunning = false;
                            break;
                        }
                        Console.WriteLine($"{userMonster.Name} has fended off the townfolk but has been wounded.");
                        Thread.Sleep(2500);
                        break;
                    case 3:
                        userMonster.RestAndRecover();
                        // Checks to make sure you don't go over your Stamina/Health maxes set at instance creation 
                        if (userMonster.Health > userCalculatedHealthMax)
                        {
                            userMonster.Health = userCalculatedHealthMax;
                        }
                        if (userMonster.Stamina > userCalculatedStaminaMax)
                        {
                            userMonster.Stamina = userCalculatedStaminaMax;
                        }
                        break;
                    case 4:
                        //ends program and Monster instance
                        isRunning = false;
                        Console.WriteLine("\nMaybe this was not an ethical idea - I should rethink my life.");
                        break;
                    default:
                        Console.WriteLine("I did not understand your input.");
                        break;
                }
            }
        }

        // -------------------------------- METHODS -------------------------------------------
        static void LightningFlashes()
        {
            int counter = 10;
            for (int i = 0; i <= counter; i++)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n");
                Thread.Sleep(75);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n                                                                                                                                                                                                                                       \n");
                Thread.Sleep(75);
                Console.Clear();
            }
        }
        static int MonsterCreationInterface()
        {
            int userChoice;
            Console.WriteLine("What would you like to add to your monster?");
            Console.WriteLine("1. Name\n2. Arms\n3. Legs\n4. Body\n5. Brain");
            Console.Write("Please make your selection: ");
            return userChoice = Convert.ToInt32(Console.ReadLine());
        }
        static string MonsterNaming()
        {
            Console.Clear();
            Console.Write("Please write a name to call your monster: ");
            return Console.ReadLine();
        }
        static string MonsterArmsChoice()
        {
            Console.Clear();
            Console.WriteLine("Master...What arms should I find for our monster? \n1. The arms of a swimmer\n2. The arms of a bodybuilder\n3. The arms of a musician\n");
            Console.Write("Please make your choice: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    return "swimmer"; //should be a choice that represents high stamnina, low dexterity, medium stregth
                case 2:
                    return "bodybuilder"; //should be a choice that represents high strength, medium stamina, low dexterity
                case 3:
                    return "musician"; //should be a choice that represents high dexterity, medium stamina, low strength
                default:
                    return null;
            }
        }
        static string MonsterLegsChoice()
        {
            Console.Clear();
            Console.WriteLine("Master...What legs should I find for our monster? \n1. The legs of a laborer\n2. The legs of a triathlete\n3. The arms of a swordfighter\n");
            Console.Write("Please make your choice: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    return "laborer"; //should be a choice that represents high strength, med stamina, low dexterity
                case 2:
                    return "triathlete"; // should be a choice that represents medium strength, medium stamina, medium dexterity 
                case 3:
                    return "swordfighter"; // should be a choice that represents low strength, med stamina, high dexterity
                default:
                    return null;
            }
        }
        
        //TODO clarify the role of this choice for more of an impact on the overall creature creation
        static string MonsterBodyChoice()
        {
            Console.Clear();
            Console.WriteLine("Sir, we are making progress...What body should I find for our monster? \n1. The body of a your average man\n2. The body of a short man\n3. The body of a tall man\n");
            Console.Write("Please make your choice: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    return "average man"; //medium health
                case 2:
                    return "short man"; //medium health
                case 3:
                    return "tall man"; // medium health
                default:
                    return null;
            }
        }
        static string MonsterBrainChoice()
        {
            Console.Clear();
            Console.WriteLine("Master!!! A most important choice lies in front of you.\nFrom whom should I select the brain for our monster? \n1. A Genius\n2. A Normal Man\n3. \"Abbie\"-someone \n");
            Console.Write("Please make your choice: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    return "genius"; //set as high intelligence
                case 2:
                    return "average"; //set as medium intelligence
                case 3:
                    return "abnormal"; //set as low intelligence
                default:
                    return null;
            }
        }
        
        //TODO compact the various Calculations through enumeration (Didn't think of this or feel like I could do this until last night)
        
        static int CalculateStrength(string userArms, string userLegs)
        {
            int calculatedStrength = 0;
            if (userArms == "bodybuilder")
            {
                calculatedStrength += 10;
            }
            else if (userArms == "swimmer")
            {
                calculatedStrength += 8;
            }
            else if (userArms == "musician")
            {
                calculatedStrength += 5;
            }
            if (userLegs == "laborer")
            {
                calculatedStrength += 10;
            }
            else if (userLegs == "triathlete")
            {
                calculatedStrength += 8;
            }
            else if (userLegs == "swordfighter")
            {
                calculatedStrength += 5;
            }
            return calculatedStrength;
        }
        
        static int CalculateDexterity(string userArms, string userLegs)
        {
            int calculatedDexterity = 0;
            if (userArms == "bodybuilder")
            {
                calculatedDexterity += 5;
            }
            else if (userArms == "swimmer")
            {
                calculatedDexterity += 8;
            }
            else if (userArms == "musician")
            {
                calculatedDexterity += 10;
            }
            if (userLegs == "laborer")
            {
                calculatedDexterity += 5;
            }
            else if (userLegs == "triathlete")
            {
                calculatedDexterity += 8;
            }
            else if (userLegs == "swordfighter")
            {
                calculatedDexterity += 10;
            }
            return calculatedDexterity;
        }
        
        static int CalculateStamina(string userArms, string userLegs, string userBody)
        {
            int calculatedStamina = 0;
            if (userArms == "bodybuilder")
            {
                calculatedStamina += 8;
            }
            else if (userArms == "swimmer")
            {
                calculatedStamina += 10;
            }
            else if (userArms == "musician")
            {
                calculatedStamina += 8;
            }
            if (userLegs == "laborer")
            {
                calculatedStamina += 8;
            }
            else if (userLegs == "triathlete")
            {
                calculatedStamina += 8;
            }
            else if (userLegs == "swordfighter")
            {
                calculatedStamina += 8;
            }
            if (userBody == "average man")
            {
                calculatedStamina += 8;
            }
            else if (userBody == "short man")
            {
                calculatedStamina += 8;
            }
            else if (userBody == "tall man")
            {
                calculatedStamina += 8;
            }
            return calculatedStamina;
        }
       
        //TODO make this stat have more interaction with the character creation process
        static int CalculateHealth(string userBody)
        {
            int calculatedHealth = 30;
            return calculatedHealth;
        }
        
        static int CalculateIntelligence(string userBrain)
        {
            int calculatedIntelligence = 0;
            if (userBrain == "genius")
            {
                calculatedIntelligence += 20;
            }
            else if (userBrain == "average")
            {
                calculatedIntelligence += 15;
            }
            else if (userBrain == "abnormal")
            {
                calculatedIntelligence += 10;
            }
            return calculatedIntelligence;
        }
    }
        
}