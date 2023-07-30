namespace STG1_LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            // Task 1: List of Numbers
            List<int> numbers = new List<int> { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            var NumbersSorted = numbers.Distinct().OrderBy(n => n);

            Console.WriteLine("Task 1: Query 1 ");
            foreach (var n in NumbersSorted)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("-----------------------------------------------------------");


            var Multiply = NumbersSorted.Select(n => $"{n} Multiply {n} = {n * n}");

            Console.WriteLine("Task 1: Query 2");
            foreach (var result in Multiply)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine("-----------------------------------------------------------");
            // Task 2: Array of Names
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
            var nLengththree = names.Where(name => name.Length == 3);

            Console.WriteLine("Task 2: Query 1");
            foreach (var name in nLengththree)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----------------------------------------------------------");

            var Aname = names.Where(name => name.ToLower().Contains("a")).OrderBy(name => name.Length);

            Console.WriteLine("Task 2: Query 2");
            foreach (var name in Aname)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----------------------------------------------------------");

            // Task 3 : list of students
            List<Student> students = new List<Student>
        {
            new Student {ID = 1, FirstName = "Ali", LastName = "Mohammed",
                Subjects = new Subject[]{new Subject {Code = 22, Name = "EF"}, new Subject {Code = 33, Name = "UML" } } },
            new Student {ID = 2, FirstName = "Mona", LastName = "Gala",
                Subjects = new Subject[]{new Subject {Code = 22, Name = "EF"}, new Subject {Code = 34, Name = "XML" }, new Subject { Code = 25, Name = "JS" } } },
            new Student {ID = 3, FirstName = "Yara", LastName = "Yosuf",
                Subjects = new Subject[]{new Subject {Code = 22, Name = "EF"}, new Subject { Code = 25, Name = "JS" } } },
            new Student {ID = 1, FirstName = "Ali", LastName = "Ali",
                Subjects = new Subject[]{new Subject {Code = 33, Name = "UML" } } }
        };

            
            var NameSubjectStd = students.Select(s => new
            {
                FullName = $"{s.FirstName} {s.LastName}",
                SubjectsCount = s.Subjects.Length
            });

            Console.WriteLine("Task 3: QUERY 1");
            foreach (var s in NameSubjectStd)
            {
                Console.WriteLine($"{s.FullName} - NoOfSubjects: {s.SubjectsCount}");
            }

            Console.WriteLine("-----------------------------------------------------------");

            var SortedNames = students.OrderByDescending(s => s.FirstName).ThenBy(s => s.LastName).Select(s => new { s.FirstName, s.LastName });

            Console.WriteLine("Task 3: QUERY 2");
            foreach (var n in SortedNames)
            {
                Console.WriteLine($"{n.FirstName} {n.LastName}");
            }
        }
    }
}
