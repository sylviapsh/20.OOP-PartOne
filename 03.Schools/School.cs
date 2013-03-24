using System.Collections.Generic;
using System.Text;

namespace Schools
{
    public class School
    {
        //Fields
        private string title;
        private List<SchoolClass> schoolClasses;

        //Properties
        public List<SchoolClass> SchoolClasses
        {
            get { return schoolClasses; }
            set { schoolClasses = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        //Constructor
        public School(string title) : this(title, null) { }

        public School(string title, List<SchoolClass> schoolClasses)
        {
            this.title = Title;
            this.schoolClasses = new List<SchoolClass>();
        }

        //Method add class
        public void AddSchoolClass(SchoolClass newSchoolClass)
        {
            this.SchoolClasses.Add(newSchoolClass);
        }

        //Ovveride ToString()
        public override string ToString()
        {
            StringBuilder schoolPrint = new StringBuilder();
            schoolPrint.AppendLine(Title.ToString());
            for (int i = 0; i < SchoolClasses.Count; i++)
            {
                schoolPrint.AppendLine(SchoolClasses[i].ToString());
            }
            schoolPrint.AppendLine();

            return schoolPrint.ToString();
        }

      
    }
}
