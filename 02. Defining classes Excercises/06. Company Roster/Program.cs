using System;
using System.Collections.Generic;
using System.Linq;

public class CompanyRoster
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var employees = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split(' ');
            var name = tokens[0];
            var salary = decimal.Parse(tokens[1]);
            var position = tokens[2];
            var department = tokens[3];
            var newEmployee = new Employee(name, salary, position, department);

            if (tokens.Length >= 5)
            {
                if (tokens.Length == 6)
                {
                    newEmployee.Email = tokens[4];
                    newEmployee.Age = int.Parse(tokens[5]);
                }
                else
                {
                    int age;
                    if (Int32.TryParse(tokens[4], out age)) newEmployee.Age = age;
                    else newEmployee.Email = tokens[4];
                }
            }
            employees.Add(newEmployee);
        }
        
        var bestDepartment = employees
            .GroupBy(employee => employee.Department, employee => employee.Salary)
            .OrderByDescending(departmentGroup => departmentGroup.Sum() / departmentGroup.Count())
            .First()
            .Key;

        var fromDepartment = employees
            .Where(employee => employee.Department == bestDepartment)
            .OrderByDescending(employee => employee.Salary);

        Console.WriteLine($"Highest Average Salary: {bestDepartment}");

        Console.WriteLine(string.Join(Environment.NewLine, fromDepartment));
    }
}