using System.Text;

namespace Humans
{
    public abstract class Human
    {
        //Fields
        private string firstName;
        private string lastName;

        //Properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        //Constructor
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //ovveride ToString()
        public override string ToString()
        {
            StringBuilder humanPrint = new StringBuilder();
            humanPrint.AppendFormat("{0} {1}", FirstName, LastName);
            return humanPrint.ToString();
        }
    }
}
