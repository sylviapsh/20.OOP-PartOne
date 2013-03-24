using System;

namespace Animals
{
    public class Dog : Animal, ISound
    {
       public Dog(string name, int age, string sex) : base(name, age, sex) { }

       public void ProduceSound()
       {
           Console.WriteLine("{0} the {1} barks: wow-wow", Name, GetType().Name );
       }
    }
}
