namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game traveler, your journey awaits you.");
            Console.WriteLine("Your goal will be to walk along pathways and find gold,");
            Console.WriteLine("but be careful as some creatures in the forest can kill you while collecting the gold\n");
            Console.WriteLine("Start? (Y/N)");
            bool playing = false;
            string[] items = {""};
            int gold = 0;

            string? startInput = Console.ReadLine();
            startInput = startInput.ToUpper();

            if (startInput == "Y")
            {
                playing = true;
            } 
            else if (startInput == "N")
            {
                Console.WriteLine("\nHave a great day then!");
            } 
            else
            {
                Console.WriteLine("\nYour input is not a valid answer.");
            }


            while (playing)
            {
                Console.WriteLine($"You have {gold} gold.");
                Console.WriteLine("Would you like to keep on walking? (Y/N)");
                string? playingInput = Console.ReadLine();
                playingInput = playingInput.ToUpper();


                if (playingInput == "Y")
                {
                    Console.WriteLine("Which pathway do you want to take?");
                    Console.WriteLine("forest or cave");
                    string? pathwayAnswer = Console.ReadLine();
                    pathwayAnswer = pathwayAnswer.ToLower();

                    Random random = new Random();
                    int creatureChance = random.Next(1, 3);

                    switch (pathwayAnswer)
                    {
                        case "forest":
                            if (creatureChance == 1)
                            {
                                
                            }
                            else
                            {

                            }
                            break;

                        case "cave":

                            break;
                    }

                    
                }
                else if (playingInput == "N")
                {
                    playing = false;
                }
                else
                {
                    Console.WriteLine("Invalid answer. \n");
                }

                }
                Console.WriteLine("stats");
            }
        }
    }