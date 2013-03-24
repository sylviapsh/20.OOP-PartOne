using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schools
{
    public class Student : Person, ICommentable
    {
        //Field
        private int id_student;

        //Property
        public int ID_student
        {
            get { return id_student; }
            set { id_student = value; }
        }

        public List<string> Comments
                { get; set; }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }

        //Constructors
        
        public Student(string name, int id_student)
        {
            this.Name = name;
            this.ID_student = id_student;
            this.Comments = new List<string>();
        }

        public override string ToString()
        {
            StringBuilder studentBuilder = new StringBuilder();
            studentBuilder.Append(String.Format("{0}. {1}", ID_student, Name));
            for (int i = 0; i < Comments.Count; i++)
            {
                studentBuilder.AppendLine(Comments[i].ToString());
            }
           
            return studentBuilder.ToString();
        }
    }
}
