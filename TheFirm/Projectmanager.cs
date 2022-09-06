using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    class ProjectManager : Manager
    {
        // Properties
        protected internal string email;

        // Encapsulations
        public string Email { get => email; }

        // Constructor
        public ProjectManager(string name, string surname, string cpr, string phoneNumber, string email) : base(name, surname, cpr, phoneNumber)
        {
            this.email = email;
        }

        // Overrides the method from the Employee class
        protected internal override void GetProperties()
        {
            Console.WriteLine("Project manager");
            Console.WriteLine("Navn: " + Name + ", Efternavn: " + Surname + ", CPR: " + Cpr + ", Mobil: " + PhoneNumber + ", Email: " + Email);
            Console.WriteLine();
        }
    }
}
