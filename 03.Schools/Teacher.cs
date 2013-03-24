using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schools
{
    public class Teacher : Person, ICommentable
    {
        //Field
        private List<Discipline> disciplines;

        //Properties
        public List<Discipline> Disciplines
        {
            get { return disciplines; }
            set { disciplines = value; }
        }

        public List<string> Comments
        { get; set; }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }

        //Constructor
        public Teacher(string name, List<Discipline> disciplines)
        {
            this.Name = name;
            this.Disciplines = disciplines;
            this.Comments = new List<string>();
        }

        public override string ToString()
        {
            StringBuilder teacherBuilder = new StringBuilder();
            teacherBuilder.AppendLine(Name);
            teacherBuilder.AppendLine("Teaches the following disciplines:");
            teacherBuilder.AppendLine(new string('-', 25));

            for (int i = 0; i < Disciplines.Count; i++)
            {
                teacherBuilder.AppendLine(Disciplines[i].ToString());
            }

           
            for (int j = 0; j < this.Comments.Count; j++)
            {
                teacherBuilder.AppendFormat("Teacher Comment {0}:", j+1);
                teacherBuilder.AppendLine();
                teacherBuilder.AppendLine(Comments[j].ToString());
            }
            return teacherBuilder.ToString();
        }
    }
}
