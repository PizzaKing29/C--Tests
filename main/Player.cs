#nullable disable
namespace Main
{
    public class Player
    {
        public static void Health (int healthDistributed, bool attacked)
        {
            if (attacked)
            {
                Program.health -= healthDistributed;
            }
            else
            {
                Program.health += healthDistributed;
            }
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