using CleanCodeLabs.Codelab03.Ducks;

namespace CleanCodeLabs.Codelab03
{
    public class Pool
    {
        public void OpenForBusiness(params Bird[] birds)
        {
            Quack(birds);
            Swim(birds);
        }

        private void Quack(Bird[] birds)
        {
            foreach (var bird in birds)
            {
                if (birds.GetType() == typeof(ElectronicDuck))
                {
                    ((ElectronicDuck)bird).TurnOn();
                }

                bird.Quack();
            }
        }

        private void Swim(Bird[] birds)
        {
            foreach (var bird in birds)
            {
                if (bird is Duck)
                {
                    (bird as Duck).Swim();
                }
            }
        }
    }
}