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
        private string cpr;

        // Encapsulations
        public string Name { get => name; }
        public string Surname { get => surname; }
        public string Cpr { get => cpr; }

        // Constructor
        public Employee(string name, string surname, string cpr)
        {
            this.name = name;
            this.surname = surname;
            this.cpr = cpr;
        }

        // Makes a abstract method that the subclasses can initiate and override
        protected internal abstract void GetProperties();
    }
}
