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

        protected internal override void GetProperties()
        {
            Console.WriteLine("Sweeper");
            Console.WriteLine("Navn: " + Name + ", Efternavn: " + Surname + ", CPR: " + Cpr);
            Console.WriteLine();
        }
    }
}
