using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    public class Solution
    {
        public static void Main()
        {
            int countOfEmployees = int.Parse(Console.ReadLine());

            var employees = new List<Employee>();

            for (int i = 0; i < countOfEmployees; i++)
            {
                string str = Console.ReadLine();
                string[] strArr = str.Split(' ');
                employees.Add(new Employee
                {
                    FirstName = strArr[0],
                    LastName = strArr[1],
                    Company = strArr[2],
                    Age = int.Parse(strArr[3])
                });
            }

            foreach (var emp in AverageAgeForEachCompany(employees))
            {
                Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in CountOfEmployeesForEachCompany(employees))
            {
                Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in OldestAgeForEachCompany(employees))
            {
                Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
            }
        }
        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            var dict = new Dictionary<string, int>();

            foreach (var employee in employees)
            {
                if (!dict.ContainsKey(employee.Company))
                {
                    var averageAge = employees
                        .Where(e => e.Company == employee.Company)
                        .Average(e => e.Age);

                    dict.Add(employee.Company, (int)Math.Round(averageAge));
                }
            }

            return dict.OrderBy(e => e.Key).ToDictionary(x => x.Key, y => y.Value);
        }

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            var dict = new Dictionary<string, int>();

            foreach (var employee in employees)
            {
                if (!dict.ContainsKey(employee.Company))
                {
                    var totalEmployees = employees
                        .Count(e => e.Company == employee.Company);

                    dict.Add(employee.Company, totalEmployees);
                }
            }

            return dict.OrderBy(e => e.Key).ToDictionary(x => x.Key, y => y.Value);
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            var dict = new Dictionary<string, Employee>();

            foreach (var employee in employees)
            {
                if (!dict.ContainsKey(employee.Company))
                {
                    var oldestEmployee = employees
                        .Where(e => e.Company == employee.Company)
                        .OrderByDescending(e => e.Age)
                        .First();

                    dict.Add(employee.Company, oldestEmployee);
                }
            }

            return dict.OrderBy(e => e.Key).ToDictionary(x => x.Key, y => y.Value);
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }
}