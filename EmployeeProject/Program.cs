using System;

namespace EmployeeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[2];
            employees[0] = new ContractualEmployee();
            employees[1] = new CasualEmployee();
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(((IEmployeeDetails)employees[i]).GetEmployeeDetails(1245));
            }
        }
    }
}