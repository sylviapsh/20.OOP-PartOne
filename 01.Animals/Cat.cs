using System;

namespace Animals
{
    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, string sex) : base(name, age, sex) { }

        public void ProduceSound()
        {
            Console.WriteLine("{0} the {1} meows: meow-meow", Name, GetType().Name);
        }
    }
}
