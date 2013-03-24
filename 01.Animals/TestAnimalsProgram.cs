using System;

namespace Animals
{
    class TestAnimalsProgram
    {
        static void Main()
        {
            Dog[] dogsArray = {
                                 new Dog ("Sharo", 3, "male"),
                                 new Dog ("Reks", 2, "male"),
                                 new Dog ("Diva", 1, "female"),
                                 new Dog ("Atila", 3, "male"),
                                 new Dog ("Ronia", 2, "female")
                             };

            Cat[] catsArray = {
                                 new Cat ("Linda", 5, "female"),
                                 new Cat ("Reksy", 2, "male"),
                                 new Cat ("Lula", 1, "female"),
                                 new Cat ("Scruffy", 7, "male"),
                                 new Cat ("Lucky", 1, "female")
                             };

            Frog[] frogsArray = {
                                 new Frog ("Tuti", 1, "female"),
                                 new Frog ("Muti", 0, "male"),
                                 new Frog ("Kuku", 1, "female"),
                                 new Frog ("Lulu", 0, "male"),
                                 new Frog ("Mumu", 0, "female")
                             };

            Kitten Kitty = new Kitten("Kitty", 2);

            //Test what animals say
            dogsArray[3].ProduceSound();
            catsArray[4].ProduceSound();
            frogsArray[0].ProduceSound();
            Kitty.ProduceSound();
            Console.WriteLine();

            //Print the avg age of each group of animals on the console
            Console.WriteLine("The average age of the dogs is: {0:F1} year/s/", Animal.CalculateAvgAge(dogsArray));
            Console.WriteLine("The average age of the cats is: {0:F1} year/s/", Animal.CalculateAvgAge(catsArray));
            Console.WriteLine("The average age of the frogs is: {0:F1} year/s/", Animal.CalculateAvgAge(frogsArray));
        }
    }
}
