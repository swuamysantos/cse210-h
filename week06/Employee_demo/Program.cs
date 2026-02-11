using System;

namespace Employee_demo
{
    public class SalaryEmployee : Employee
    {
        class Program
        {
            static void Main(string[] args)
            {
                HourlyEmployee hEmployee = new HourlyEmployee();
                hEmployee.SetName("John");
                hEmployee.SetIdNumber("123abc");
                hEmployee.SetPayRate(15);
                hEmployee.SetHoursWorked(35);

                SalaryEmployee sEmployee = new SalaryEmployee();
                sEmployee.SetName("Jane");
                sEmployee.SetIdNumber("678def");
                sEmployee.SetSalary(60000);

                DisplayEmployeeInformation(hEmployee);
                DisplayEmployeeInformation(sEmployee);
            }

            public static void DisplayEmployeeInfo(Employee employee)
            {
                Console.WriteLine($"{employee.GetName()}");
                

            }
        }

    }
}