using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schools
{
    public class SchoolClass : ICommentable
    {
        //Fields
        private string idClass;
        private List<Student> students;
        private List<Teacher> teachers;

        //Properties
        public List<Teacher> TeachersClassProperty
        {
            get { return teachers; }
            set { teachers = value; }
        }

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        public string IDclass
        {
            get { return idClass; }
            set { idClass = value; }
        }

         public List<string> Comments 
                { get; set; }
        
        //Constructors
        public SchoolClass(string idClass, List<Student> students, List<Teacher> teachers)
        {
            this.IDclass = idClass;
            this.Students = new List<Student>();
            this.TeachersClassProperty = new List<Teacher>();
            this.Comments = new List<string>();
        }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            TeachersClassProperty.Add(teacher);
        }

        public override string ToString()
        {
            StringBuilder schoolClassBuilder = new StringBuilder();
            schoolClassBuilder.AppendLine(IDclass);
            schoolClassBuilder.AppendLine("Students");
            for (int i = 0; i < Students.Count; i++)
            {
                schoolClassBuilder.AppendLine(Students[i].ToString());
            }
            schoolClassBuilder.AppendLine("Teachers");
            for (int i = 0; i < TeachersClassProperty.Count; i++)
            {
                schoolClassBuilder.AppendLine(TeachersClassProperty[i].ToString());
            }
            
            return schoolClassBuilder.ToString();
        }
    }
}
