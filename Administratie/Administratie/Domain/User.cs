using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administratie.Domain
{
    public class User
    {
        //variabele
        private String Email;
        private String Name;
        private String Surename;
        private int PhoneNumber;
        private String Postalcode;

        //Constraint
        public User(String Email, String Name, String Surename, int PhoneNumber, String Postalcode) {
            this.Emails = Email;
            this.Name = Name;
            this.Surename = Surename;
            this.PhoneNumber = PhoneNumber;
            this.Postalcode = Postalcode;
        }

        //Module
        public string Emails { get => Email; set => Email = value; }
        public string Names { get => Name; set => Name = value; }
        public string Surenames { get => Surename; set => Surename = value; }
        public int PhoneNumbers { get => PhoneNumber; set => PhoneNumber = value; }
        public string Postalcodes { get => Postalcode; set => Postalcode = value; }
    }
}
