#nullable disable
namespace Main
{
    public class Player
    {
        public static void Health (int healthGained, int healthLost)
        {
            if ()
        }

        public static void Gold (int goldDistributed, bool attacked)
        {
            if (attacked)
            {
                Program.gold -= goldDistributed;
            }
            else
            {
                Program.gold += goldDistributed;
            }
        }
    }
}