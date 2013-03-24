using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools
{
    public class TestSchoolProgram
    {
        static void Main()
        {
            //Create a school
            School testSchool = new School("40 - SOU Loui Pastior");
            testSchool.Title = "40 - SOU Loui Pastior";

            //Add disciplines
            Discipline maths = new Discipline("Mathematics", 30, 30);
            Discipline bgLang = new Discipline("Bulgarian Language", 30, 30);
            Discipline enLang = new Discipline("English Language", 20, 20);

            //Add Students
            Student Ivanov = new Student("Ivan Ivanov", 1);
            Student Petrov = new Student("Ivan Petrov", 2);
            Student Ivanova = new Student("Petia Ivanova", 1);
            Student Ilieva = new Student("Kalina Ilieva", 2);
            Student Kostov = new Student("Jordan Kostov", 3);
            Student Kirchev = new Student("Pencho Kirchev", 4);

            //Add Teachers
            Teacher Petrova = new Teacher("Tania Petrova", new List<Discipline> {maths, enLang });
            Teacher Georgiev = new Teacher("Georgi Georgiev", new List<Discipline> { bgLang, enLang });

            //Add some comments
            Georgiev.AddComment("Only morning classes");
            Georgiev.AddComment("Free Wednesdays");
            Ivanova.AddComment("Not present every second Tuesday due to medical issues");

           
            //Add 2 classes
            SchoolClass firstA = new SchoolClass("I A", new List<Student>() , new List<Teacher> ());
            firstA.AddStudent(Ivanov);
            firstA.AddStudent(Petrov);
            firstA.AddStudent(Kostov);
            firstA.AddStudent(Kirchev);
            firstA.AddTeacher(Petrova);

            testSchool.AddSchoolClass( firstA);

           SchoolClass firstB = new SchoolClass("I B", new List<Student> (), new List<Teacher>());
           firstB.AddStudent(Ivanova);
           firstB.AddStudent(Ilieva);
           firstB.AddTeacher(Petrova);
           firstB.AddTeacher(Georgiev);
           testSchool.AddSchoolClass(firstB);

            //Print on the console
            Console.WriteLine("Information about a discipline:");
            Console.WriteLine(maths);
            Console.WriteLine();
            Console.WriteLine("Information about a teacher:");
            Console.WriteLine(Georgiev);
            Console.WriteLine();
            Console.WriteLine("Information about a student:");
            Console.WriteLine(Ilieva);
            Console.WriteLine();
            Console.WriteLine("Information about a school class:");
            Console.WriteLine(firstA);
            Console.WriteLine();
            Console.WriteLine("Information about a school:");
            Console.WriteLine(testSchool);
            
        }
    }
}
