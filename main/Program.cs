#nullable disable

namespace Main
{
    public class Program
    {

        public static bool playing = false;
        // public static string[] items = {""};     to be implemented soon
        public static int gold = 0;
        public static int health = 100;
        public static string input = "";
        public static Random randomCreature = new Random();
        public static Random randomGold = new Random();
        public static Random randomHealth = new Random();
        public static Random randomTreasure = new Random();
        public static int creatureChance = randomCreature.Next(1, 3);
        public static int goldFound = randomGold.Next(1, 26);
        public static int healthLost = randomHealth.Next(1, 33);
        public static int treasureChance = randomTreasure.Next(1, 21);

        public static void Main()
        {   
            Game.Loop();
        }
            public static void DisplayStats ()
            {
                Console.WriteLine($"Your health is {health} points.");
                Console.WriteLine($"You have {gold} gold.");
                Console.WriteLine("Would you like to keep on walking? (Y/N)");
            }

            public static void HandleEncounter (string pathwawyAnswer)
            {
                UpdateRandom();

                switch (pathwawyAnswer)
                    {
                        case "forest":

                            if (treasureChance == 1)
                            {
                                HiddenTreasure();
                            }
                            else if (creatureChance == 1)
                            {
                                Player.Gold(goldFound, false); // adds goldFound to gold
                                Player.Health(healthLost, false); // adds health found
                                Console.Clear();
                                Console.WriteLine($"\nYou have found {goldFound} gold, awesome!");
                            }
                            else
                            {
                                if (gold > 0 && goldFound < gold) // makes sure gold cannot go in the negatives
                                {
                                    Player.Gold(goldFound, true); // subtracts goldFound to gold
                                }
                                Player.Health(healthLost, true); // subtracts health found
                                Console.Clear();
                                Console.WriteLine($"\nYou have lost {goldFound} gold, and a bear has attacked you!");
                                Console.WriteLine($"You have also lost {healthLost} health, uh oh!\n");
                                
                            }
                            break;

                        case "cave":

                            if (treasureChance == 1)
                            {
                                HiddenTreasure();
                            }
                            else if(creatureChance == 1)
                            {
                                Console.Clear();
                                Player.Gold(goldFound, false); // adds goldFound to gold
                                Console.WriteLine($"\nYou have found {goldFound} gold, awesome!");
                            }
                            else
                            {

                                if (gold > 0 && goldFound < gold) // makes sure gold cannot go in the negatives
                                {
                                    Player.Gold(goldFound, true); // subtracts goldFound to gold
                                }
                                Player.Health(healthLost, true); // subtracts health found
                                Console.Clear();
                                Console.WriteLine($"\nYou have lost {goldFound} gold, and a snake has attacked you!");
                                Console.WriteLine($"You have also lost {healthLost} health, uh oh!\n");
                                
                            }
                            break;

                        default:
                            ValidateInput("Please enter 'forest' or 'cave'. Press ENTER to return.");
                        break;
                    }
            }

            public static string ValidateInput (string message)
            {
                Console.WriteLine(message);

                return Console.ReadLine();
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
                else if(health < 1 && gold < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for playing! Unfortunatley you have died, yikes...");
                    Console.WriteLine($"You also ended with {gold} gold, better luck next time!");
                }
            }

            public static void HiddenTreasure ()
            {
                Player.Gold(goldFound + 100, false); // adds goldFound to gold
                Console.Clear();
                Console.WriteLine($"\nYou have found the buried treasure and found {goldFound + 100} gold!");
            }

            public static void UpdateRandom ()
            {
                creatureChance = randomCreature.Next(1, 3);
                goldFound = randomGold.Next(1, 26);
                healthLost = randomHealth.Next(1, 33);
                treasureChance = randomTreasure.Next(1, 21);
            }
        }
    }