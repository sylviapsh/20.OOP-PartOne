using System;
using System.Collections.Generic;
using System.Linq;

namespace Humans
{
    class TestHumansProgram
    {
        static void Main()
        {
            //Initialize 10 students
            List <Student> studentsList = new List<Student>();
            studentsList.Add(new Student("Albena", "Albenkova", 6));
            studentsList.Add(new Student("Ivan", "Ivanov", 6));
            studentsList.Add(new Student("Petar", "Junkov", 3));
            studentsList.Add(new Student("Julian", "Junkov", 5));
            studentsList.Add(new Student("Albena", "Valodova", 4));
            studentsList.Add(new Student("Hristina", "Kukenska", 5));
            studentsList.Add(new Student("Lilia", "Donova", 5));
            studentsList.Add(new Student("Krasimir", "Krasimirov", 4));
            studentsList.Add(new Student("Jordan", "Avramov", 5));
            studentsList.Add(new Student("Albena", "Denkova", 3));

            //Sort students with LINQ
            var studentSorted = from student in studentsList
                                 orderby student.Grade ascending
                                 select student;

            //Print the sorted list of students
            Console.WriteLine("Students sorted ascendingly by grade:");
            Console.WriteLine();
            foreach (var student in studentSorted)
            {
                Console.WriteLine(student);
            }

            //Initialize 10 workers
            List<Worker> workersList = new List<Worker>();
            workersList.Add(new Worker("John", "Dow", 300, 6));
            workersList.Add(new Worker("Penio", "Gusev", 200, 8));
            workersList.Add(new Worker("Gocho", "Sterev", 350, 6));
            workersList.Add(new Worker("Katia", "Kamova", 400, 8));
            workersList.Add(new Worker("Plamena", "Plamenova", 100, 6));
            workersList.Add(new Worker("Sonia", "Holeva", 50, 8));
            workersList.Add(new Worker("Kosta", "Georgiev", 300, 12));
            workersList.Add(new Worker("Julia", "Djonova", 800, 24));
            workersList.Add(new Worker("Ivan", "Fomov", 290, 4.5m));
            workersList.Add(new Worker("Aladin", "Alibababov", 250.5m, 6));

            //Sort the workers by Money Per Hour with LINQ
            var workerSorted = from worker in workersList
                                orderby worker.SalaryPerHour descending
                                select worker;

            //Print the sorted worker list
            Console.WriteLine("Workers sorted descendingly by salary per hour");
            foreach (var worker in workerSorted)
            {
                Console.WriteLine(worker);
            }

            //Merge the lists of students and workers
            List<Human> mergedList = new List<Human>();
            foreach (var student in studentsList)
            {
                mergedList.Add(student);
            }

            foreach (var worker in workersList)
            {
                mergedList.Add(worker);
            }
           
            //Sort the merged list
            var humansSorted = from human in mergedList
                                orderby human.FirstName, human.LastName
                                select human;

            //Print the sorted by name humans list
            Console.WriteLine("Humans sorted by name list:");
            Console.WriteLine();
            foreach (var human in humansSorted)
            {
                Console.WriteLine("{0} {1}",human.FirstName, human.LastName);
            }
        }
    }
}
