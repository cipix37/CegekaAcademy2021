using CleanCodeLabs.Codelab04.Interfaces;

namespace CleanCodeLabs.Codelab04.Workers
{
    public class Human : Worker, IAbleToEat, IAbleToWork
    {
        public Human(string name) : base(name)
        {
        }

        public string Eat()
        {
            return "Eating my 'bokes'";
        }

        public string Work()
        {
            return "Doing some hard work, but I do get tired";
        }
    }
}