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
            Employee sweeper = new Sweeper("Jens", "Jensen", 2006903030);
            Employee manager = new Manager("Lars", "Kaspersen", 2710872020, 90807060);
            Employee projectmanager = new ProjectManager("Kasper", "Larsen", 1201851010, 20304050, "KJ@firm.com");

            sweeper.GetProperties();
            manager.GetProperties();
            projectmanager.GetProperties();

            Console.ReadLine();
        }
    }
}
