using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    class Projectmanager : Manager
    {
        // Properties
        protected internal string email;

        public string Email { get => email; }

        // Constructor
        public Projectmanager(string name, string surname, double cpr, int phoneNumber, string email) : base(name, surname, cpr, phoneNumber)
        {
            this.email = email;
        }

        public void GetProperties()
        {
            Console.WriteLine("Project manager");
            Console.WriteLine("Navn: " + Name + ", Efternavn: " + Surname + ", CPR: " + Cpr + ", Mobil: " + PhoneNumber + ", Email: " + Email);
            Console.WriteLine(Name.GetTypeCode() + " " + Surname.GetTypeCode() + " " + Cpr.GetTypeCode() + " " + PhoneNumber.GetTypeCode() + " " + Email.GetTypeCode());
            Console.WriteLine();
        }
    }
}
