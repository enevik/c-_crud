using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Domain
{
    public class User
    {
        //prive variablen aangemaakt!
        private String Name;
        private String Email;
        private String PostalCode;
        private String City;

        //Constructor aangemaakt
        public User(String Name, String Email, String PostalCode, String City) {
            this.Name1 = Name;
            this.Email1 = Email;
            this.PostalCode1 = PostalCode;
            this.City1 = City;
        }


        //GETTER EN SETTER GEMAAKT!
        public string Name1 { get => Name; set => Name = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string PostalCode1 { get => PostalCode; set => PostalCode = value; }
        public string City1 { get => City; set => City = value; }
    }
}
