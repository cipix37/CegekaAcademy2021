using System;

namespace CleanCodeLabs.Codelab02
{
    public abstract class Slot
    {
        public virtual void MarkSlotFree(int resourceId)
        {
            Console.WriteLine("General slot Marked as free for resourceId = " + resourceId);
        }

        public virtual void MarkSlotBusy(int resourceId)
        {
            Console.WriteLine("General slot Marked as busy for resourceId = " + resourceId);
        }

        public abstract int FindFreeSlot();
    }
}
