using System.Security.Cryptography.X509Certificates;

namespace Main
{
    class Program
    {

        public static bool playing = false;
        public static string[] items = {""};
        public static int gold = 0;
        public static int health = 100;
        public static Random randomCreature = new Random();
        public static Random randomGold = new Random();
        public static Random randomHealth = new Random();
        public static int creatureChance = randomCreature.Next(1, 3);
        public static int goldFound = randomGold.Next(1, 26);
        public static int healthLost = randomHealth.Next(1, 33);

        public static void Main(string[] args)
        {   
            Console.Clear();
            Console.WriteLine("Welcome to the game traveler, your journey awaits you.");
            Console.WriteLine("Your goal will be to walk along pathways and find gold,");
            Console.WriteLine("but be careful as some creatures in the forest can kill you while collecting the gold\n");
            Console.WriteLine("Start? (Y/N)");

            string? startInput = Console.ReadLine();
            startInput = startInput.ToUpper();

            if (startInput == "Y")
            {
                playing = true;
                Console.Clear();
            } 
            else if (startInput == "N")
            {
                Console.WriteLine("\nHave a great day then!");
            } 
            else
            {
                Console.WriteLine("\nYour input is not a valid answer.");
            }


            while (playing && health > 0)
            {
                Console.WriteLine($"Your health is {health} points.");
                Console.WriteLine($"You have {gold} gold.");
                Console.WriteLine("Would you like to keep on walking? (Y/N)");
                string? playingInput = Console.ReadLine();
                playingInput = playingInput.ToUpper();


                if (playingInput == "Y")
                {
                    Console.Clear();
                    Console.WriteLine("Which pathway do you want to take?");
                    Console.WriteLine("forest or cave");
                    string? pathwayAnswer = Console.ReadLine();
                    pathwayAnswer = pathwayAnswer.ToLower();
                    Console.Clear();

                    HandleEncounter(pathwayAnswer);

                    
                }
                else if (playingInput == "N")
                {
                    playing = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid answer. \n");
                }

                }
                GameOver();
            }
            public static void DisplayStats ()
            {
                Console.WriteLine($"Your health is {health} points.");
                Console.WriteLine($"You have {gold} gold.");
                Console.WriteLine("Would you like to keep on walking? (Y/N)");
            }

            public static void HandleEncounter (string pathwawyAnswer)
            {
                switch (pathwawyAnswer)
                    {
                        case "forest":
                            if (creatureChance == 1)
                            {
                                creatureChance = randomCreature.Next(1, 3);
                                goldFound = randomGold.Next(1, 26);
                                gold += goldFound;
                                Console.WriteLine($"\nYou have found {goldFound} gold, awesome!");
                                
                            }
                            else
                            {
                                creatureChance = randomCreature.Next(1, 3);
                                goldFound = randomGold.Next(1, 26);
                                healthLost = randomHealth.Next(1, 33);

                                if (gold > 0 && goldFound < gold) // makes sure gold cannot go in the negatives
                                {
                                    gold -= goldFound;
                                }
                                health -= healthLost;
                                Console.WriteLine($"\nYou have lost {goldFound} gold, and a bear has attacked you!");
                                Console.WriteLine($"You have also lost {healthLost} health, uh oh!\n");
                                
                            }
                            break;

                        case "cave":
                            if(creatureChance == 1)
                            {
                                creatureChance = randomCreature.Next(1, 3);
                                goldFound = randomGold.Next(1, 26);
                                gold += goldFound;
                                Console.WriteLine($"\nYou have found {goldFound} gold, awesome!");
                            }
                            else
                            {
                                creatureChance = randomCreature.Next(1, 3);
                                goldFound = randomGold.Next(1, 26);
                                healthLost = randomHealth.Next(1, 33);

                                if (gold > 0 && goldFound < gold) // makes sure gold cannot go in the negatives
                                {
                                    gold -= goldFound;
                                }
                                health -= healthLost;
                                Console.WriteLine($"\nYou have lost {goldFound} gold, and a snake has attacked you!");
                                Console.WriteLine($"You have also lost {healthLost} health, uh oh!\n");
                                
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid pathway choice. Please type 'forest' or 'cave'.");
                        break;
                    }
            }

            public static void ValidateInput ()
            {

            }

            public static void GameOver ()
            {
                Console.Clear();
                Console.WriteLine("Thanks for playing!");
                Console.WriteLine($"You had {health} health.");
                Console.WriteLine($"You also ended with {gold} gold!");

                if (health < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for playing! Unfortunatley you have died, yikes...");
                    Console.WriteLine($"But you ended with {gold} gold!");
                }
                else if (health < 1 && gold < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for playing! Unfortunatley you have died, yikes...");
                    Console.WriteLine($"You also ended with {gold} gold, better luck next time!");
                }
            }

            public static void HiddenTreasure ()
            {

            }
        }
    }