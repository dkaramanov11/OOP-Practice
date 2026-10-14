# Employees — Salary Calculation

Create a system for calculating employee salaries.

## Requirements

- Create a base class Employee with an employee ID and full name.
- Initialize these values through a constructor.
- Employee has a virtual method CalculateSalary() that returns 0.
- Employee has a method PrintInfo() that displays the employee ID,
  full name, and calculated salary.

- Create a class FullTimeEmployee that inherits from Employee.
- It has a monthly salary, which must not be negative.
- Override CalculateSalary() to return the monthly salary.

- Create a class PartTimeEmployee that inherits from Employee.
- It has hours worked and an hourly rate.
- Both values must not be negative.
- Override CalculateSalary() to return hours worked multiplied
  by the hourly rate.

- If a constructor receives a negative salary, hours worked,
  or hourly rate, display a message and set that value to 0.
- Properties can be read but must not be modified directly
  from outside the classes.
- Use decimal for monetary values and int for hours worked.

## Testing

In Main:
1. Create one full-time employee and two part-time employees.
2. Store them in a single List<Employee>.
3. Loop through the list and call PrintInfo() for each employee.
4. Verify that each employee's salary is calculated according
   to their employee type.
5. Test an employee created with a negative value.