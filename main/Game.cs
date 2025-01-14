#nullable disable
namespace Main
{
    public class Game
    {
        public static void Loop()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the game traveler, your journey awaits you.");
            Console.WriteLine("Your goal will be to walk along pathways and find gold,");
            Console.WriteLine("but be careful as some creatures in the forest can kill you while collecting the gold\n");
            Console.WriteLine("Start? (Y/N)");

            Program.input = Console.ReadLine();

            if (Program.input == "Y" || Program.input == "y")
            {
                Program.playing = true;
                Console.Clear();
            } 
            else if (Program.input == "N" || Program.input == "n")
            {
                Console.WriteLine("\nHave a great day then!");
            } 
            else
            {
                return;
            }


            while (Program.playing && Program.health > 0)
            {
                Program.DisplayStats();
                Program.input = Console.ReadLine();


                if (Program.input == "Y" || Program.input == "y")
                {
                    Console.Clear();
                    Console.WriteLine("Which pathway do you want to take?");
                    Console.WriteLine("forest or cave");
                    Program.input = Console.ReadLine();
                    Program.input = Program.input.ToLower();

                    Program.HandleEncounter(Program.input);

                    
                }
                else if (Program.input == "N" || Program.input == "n")
                {
                    Program.playing = false;
                }
                else
                {
                    Console.Clear();
                    Program.ValidateInput($"{Program.input} is an invalid input.");
                    continue;
                }

                }
                Program.GameOver();
        }
        
    }
}