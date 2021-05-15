using System;

namespace CleanCodeLabs.Codelab02
{
    public class SpaceSlot : Slot
    {
        public override void MarkSlotFree(int resourceId)
        {
            Console.WriteLine("Space slot Marked as free for resourceId = " + resourceId);
        }

        public override void MarkSlotBusy(int resourceId)
        {
            Console.WriteLine("Space slot Marked as busy for resourceId = " + resourceId);
        }

        public override int FindFreeSlot()
        {
            return new Random().Next() * 100;
        }
    }
}
