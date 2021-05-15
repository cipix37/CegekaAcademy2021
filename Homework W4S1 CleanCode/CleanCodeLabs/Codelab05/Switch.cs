using System.Drawing;

namespace CleanCodeLabs.Codelab05
{
    /// <summary>
    ///     A Switch to Turn something (in this case: a Lamp) ON or OFF
    /// </summary>
    internal class Switch
    {
        private readonly ISwitchable device = new Lamp(Color.Yellow);
        public bool IsSwitchOn { get; private set; }

        public void Toggle()
        {
            IsSwitchOn = !IsSwitchOn;
            if (IsSwitchOn)
            {
                device.TurnOn();
            }
            else
            {
                device.TurnOff();
            }
        }
    }
}