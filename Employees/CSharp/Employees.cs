using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.Employees.CSharp
{
    internal class Employee
    {
        public string EmployeeId { get; }
        public string FullName { get; }

        public Employee(string employeeId, string fullName)
        {
            this.EmployeeId = employeeId;
            this.FullName = fullName;
        }

        public virtual decimal CalculateSalary()
        {
            return 0;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Full name: {FullName}");
            Console.WriteLine($"Salary: {CalculateSalary():F2}");
        }
    }

    internal class FullTimeEmployee : Employee { 
        public decimal MonthlySalary { get; }

        public FullTimeEmployee(string employeeId, string fullName, decimal monthlySalary) : base(employeeId, fullName)
        {
            if (monthlySalary < 0)
            {
                Console.WriteLine(
                    "Monthly salary cannot be negative. Setting it to 0.");

                MonthlySalary = 0;
            }
            else
            {
                MonthlySalary = monthlySalary;
            }
        }

        public override decimal CalculateSalary()
        {
            return MonthlySalary;
        }
    }

    internal class PartTimeEmployee : Employee
    {
        public int HoursWorked { get; }
        public decimal HourlyRate { get; }

        public PartTimeEmployee(string employeeId, string fullName, int hoursWorked, decimal hourlyRate) : base(employeeId, fullName)
        {

            if (hoursWorked < 0)
            {
                Console.WriteLine("Hours worked cannot be negative. Setting them to 0.");

                HoursWorked = 0;
            }
            else
            {
                HoursWorked = hoursWorked;
            }

            if (hourlyRate < 0) 
            {
                Console.WriteLine("Hourly Rate cannot be negative. Setting them to 0.");
                
                HourlyRate = 0;
            }
            else
            {
                HourlyRate = hourlyRate;
            }
        }

        public override decimal CalculateSalary() { 
            return HoursWorked * HourlyRate;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new FullTimeEmployee(
                    "E001", "Daniel Karamanov", 45000m),

                new PartTimeEmployee(
                    "E002", "Ana Petrova", 80, 300m),

                new PartTimeEmployee(
                    "E003", "Marko Ivanov", 60, 250m)
            };

            foreach (Employee employee in employees)
            {
                employee.PrintInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Testing negative values:");

            Employee invalidEmployee = new PartTimeEmployee(
                "E004", "Test Employee", -10, -200m);

            invalidEmployee.PrintInfo();
        }
    }
}
