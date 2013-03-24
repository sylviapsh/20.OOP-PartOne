namespace Animals
{
    public abstract class Animal
    {
        //Fields
        private string name;
        private int age;
        private string sex;

        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        //Constructor
        public Animal(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        //Calculate the average age of an animal group
        public static double CalculateAvgAge(Animal[] animals)
        {
            double sum = 0;
            for (int i = 0; i < animals.Length; i++)
            {
                sum += animals[i].Age;
            }

            double avg = sum / animals.Length; //Calculate the average value

            return avg;
        }
    }
}
