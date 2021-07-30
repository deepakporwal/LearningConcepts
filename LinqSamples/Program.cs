using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jai Shree Ram ! , Welcome to LINQ");

            // declare an string array
            string[] words = {"deepak","appu","pratik","vipin","avika" };
            
            //Linq query syntax :=>  select words length > 5
            var shortWords = from word in words where word.Length >= 5 select word;

            foreach (var word in shortWords)
            {
                Console.WriteLine(word);
            }

            // Lambda syntax
            var longwords = words.Where(x => x.Length <= 5);

            Console.WriteLine(longwords.Count());

            // Specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60 };

            // Define the lambda expression.
            IEnumerable<int> scoreQuery = scores.Where(x => x > 80).ToList<int>();

            // Execute the query.

            foreach (int i in scoreQuery)
            {
                Console.WriteLine(i + " ");
            }

            // same expression in query syntax
            IEnumerable<int> scoreQuery2 = from score in scores where score > 80 select score;

            // Execute the query.

            foreach (int i in scoreQuery2)
            {
                Console.WriteLine(i + " ");
            }

            // Print list of departments
            PrintDepartment();

            Console.ReadLine();
        }

        static void PrintDepartment()
        {
            List<Department> departments = new List<Department>();

            departments.Add(new Department { DepartmentId = 1, Name = "Account" });
            departments.Add(new Department { DepartmentId = 2, Name = "Sales" });
            departments.Add(new Department { DepartmentId = 3, Name = "Marketing" });

            var departmentList = from d in departments
                                 select d;

            foreach (var dept in departmentList)
            {
                Console.WriteLine("Department Id = {0} , Department Name = {1}",
                   dept.DepartmentId, dept.Name);
            }
        }
    }
}
