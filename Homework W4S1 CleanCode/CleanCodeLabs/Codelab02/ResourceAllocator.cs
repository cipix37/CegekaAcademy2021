using System;

namespace CleanCodeLabs.Codelab02
{
    public class ResourceAllocator
    {
        public int Allocate(Slot slot)
        {
            int resourceId = slot.FindFreeSlot();
            slot.MarkSlotBusy(resourceId);
            return resourceId;
        }

        public void Deallocate(Slot slot, int resourceId)
        {
            slot.MarkSlotFree(resourceId);
        }
    }
}