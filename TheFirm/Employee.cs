using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    abstract class Employee
    {
        // Properties
        private string name;
        private string surname;
        private double cpr;

        public string Name { get => name; }
        public string Surname { get => surname; }
        public double Cpr { get => cpr; }

        // Constructor
        public Employee(string name, string surname, double cpr)
        {
            this.name = name;
            this.surname = surname;
            this.cpr = cpr;
        }

        protected internal abstract void GetProperties();
    }
}
