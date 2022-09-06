using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating employees
            Employee sweeper = new Sweeper("Jens", "Jensen", "20-06-90-3030");
            Employee manager = new Manager("Lars", "Kaspersen", "27-10-87-2020", "90 80 70 60");
            Employee projectmanager = new ProjectManager("Kasper", "Larsen", "12-01-85-1010", "20 30 40 50", "KJ@firm.com");

            // Creating the List employees
            List<Employee> employees = new List<Employee>();

            employees.Add(sweeper);
            employees.Add(manager);
            employees.Add(projectmanager);


            // A foreach that loop thourgh employees List
            foreach (Employee employee in employees)
            {
                // Calling the method GetProperties
                employee.GetProperties();
            }


            Console.ReadLine();
        }
    }
}
