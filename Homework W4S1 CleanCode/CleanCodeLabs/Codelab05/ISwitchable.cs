using System;

namespace CleanCodeLabs.Codelab05
{
    public interface ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("Generic device turned on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Generic device turned off");
        }
    }
}
