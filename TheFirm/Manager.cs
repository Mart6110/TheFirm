using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    class Manager : Employee
    {
        // Properties
        private protected int phoneNumber;

        // Encapsulations
        public int PhoneNumber { get => phoneNumber; }

        // Constructor
        public Manager(string name, string surname, double cpr, int phoneNumber) : base(name, surname, cpr)
        {
            this.phoneNumber = phoneNumber;
        }

        // Overrides the method from the Employee class
        protected internal override void GetProperties()
        {
            Console.WriteLine("Manager");
            Console.WriteLine("Navn: " + Name + ", Efternavn: " + Surname + ", CPR: " + Cpr + ", Mobil: " + PhoneNumber);
            Console.WriteLine();
        }
    }
}
