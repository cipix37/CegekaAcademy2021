using System;

namespace CleanCodeLabs.Codelab02
{
    public class TimeSlot : Slot
    {
        public override void MarkSlotFree(int resourceId)
        {
            Console.WriteLine("Time slot Marked as free for resourceId = " + resourceId);
        }

        public override void MarkSlotBusy(int resourceId)
        {
            Console.WriteLine("Time slot Marked as busy for resourceId = " + resourceId);
        }

        public override int FindFreeSlot()
        {
            return new Random().Next() * 50;
        }
    }
}
