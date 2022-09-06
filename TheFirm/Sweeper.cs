using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    class Sweeper : Employee
    {
        // Constructor
        public Sweeper(string name, string surname, double cpr) : base(name, surname, cpr) { }

        public void GetProperties()
        {
            Console.WriteLine("Sweeper");
            Console.WriteLine("Navn: " + Name + ", Efternavn: " + Surname + ", CPR: " + Cpr);
            Console.WriteLine(Name.GetTypeCode() + " " + Surname.GetTypeCode() + " " + Cpr.GetTypeCode());
            Console.WriteLine();
        }
    }
}
