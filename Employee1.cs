using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Employee details
            int employeeId = 12;
            string employeeName = "Sam";
            char employeeGender = 'M';
            decimal employeeSalary = 99000.90m;
            DateTime dateOfJoining = new DateTime(2012, 12, 12);

            // Display employee details
            Console.WriteLine("ID: {0}", employeeId);
            Console.WriteLine("Employee Name: {0}", employeeName);
            Console.WriteLine("Employee Gender: {0}", employeeGender);
            Console.WriteLine("DOJ: {0}", dateOfJoining.ToString("d"));
            Console.WriteLine("Employee Salary: {0:C}", employeeSalary);

            // Calculate and display tax amount
            decimal taxPercentage = employeeSalary > 90000 ? 0.3m : 0.15m;
            decimal taxAmount = employeeSalary * taxPercentage;
            Console.WriteLine("\nYou have to pay: {0:C}", taxAmount);

            Console.ReadLine();
        }
    }
}
