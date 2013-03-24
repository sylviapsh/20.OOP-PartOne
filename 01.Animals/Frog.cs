using System;

namespace Animals
{
    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, string sex) : base(name, age, sex) { }

        public void ProduceSound()
        {
            Console.WriteLine("{0} the {1} says: ribbit", Name, GetType().Name);
        }
    }
}
