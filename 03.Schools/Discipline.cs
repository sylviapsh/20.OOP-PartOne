using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schools
{
    public class Discipline : ICommentable
    {
        //Fields
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        //Properties
        public int NumberOfExercises
        {
            get { return numberOfExercises; }
            set { numberOfExercises = value; }
        }

        public int NumberOfLectures
        {
            get { return numberOfLectures; }
            set { numberOfLectures = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<string> Comments
        { get; set; }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }

        //Constructors
        public Discipline(string name, int numOfExercises, int numOfLectures)
        {
            this.Name = name;
            this.NumberOfExercises = numOfExercises;
            this.NumberOfLectures = numOfLectures;
            this.Comments = new List<string>();
        }

        public override string ToString()
        {
            StringBuilder disciplineBuilder = new StringBuilder();
    
            disciplineBuilder.AppendFormat("{0} {1} {2}", Name, NumberOfExercises, NumberOfLectures);
            disciplineBuilder.AppendLine();
            disciplineBuilder.AppendLine(new string('-', 25));

            for (int i = 0; i < Comments.Count; i++)
            {
                disciplineBuilder.AppendFormat("Discipline Comment {0}:", i+1);
                disciplineBuilder.AppendLine();
                disciplineBuilder.AppendLine(Comments[i].ToString());
            }

            return disciplineBuilder.ToString();
        }
    }
}
