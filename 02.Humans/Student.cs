using System.Text;

namespace Humans
{
    public class Student : Human
    {
        //Field
        private int grade;

        //SalaryPerHour
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        //Constructor
        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        //override ToString()
        public override string ToString()
        {
            StringBuilder studentPrint = new StringBuilder();
            studentPrint.AppendFormat("{0} {1} --- Grade: {2}", FirstName, LastName, Grade);
            studentPrint.AppendLine();

            return studentPrint.ToString();
        }
    }
}
