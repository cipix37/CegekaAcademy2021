using CleanCodeLabs.Codelab04.Interfaces;

namespace CleanCodeLabs.Codelab04.Workers
{
    public class Robot : Worker, IRechargeable, IAbleToWork
    {
        public Robot(string name) : base(name)
        {
        }

        public string RechargeBatteries()
        {
            return "RECHARGING BATTERIES, BEEP";
        }

        public string Work()
        {
            return "DOING SO MUCH WORK, BEEP";
        }
    }
}