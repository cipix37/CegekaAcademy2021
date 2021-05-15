using System;

namespace CleanCodeLabs.Codelab03.Ducks
{
    public class Duck : Bird
    {
        public override void Quack()
        {
            Console.WriteLine("Quack...");
        }

        public virtual void Swim()
        {
            Console.WriteLine("Swim...");
        }
    }
}