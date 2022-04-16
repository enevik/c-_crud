using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace Administratie.Expression
{
    public class RegexExpression
    {
        public static bool checkForEmail(String email)
        {
            bool IsValid = false;
            Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (r.IsMatch(email))
            {
                IsValid = true;
            }
            else
            {
                MessageBox.Show("Email niet juist ingevoerd");
            }

            return IsValid;
        }

        public static bool checkForPostalCode(String postalCode)
        {
            bool isValid = false;
            Regex regex = new Regex("^[1-9][0-9]{3}s*(?:[a-zA-Z]{2})?$");
            if (regex.IsMatch(postalCode))
            {
                isValid = true;
            } 
            else 
            {
                MessageBox.Show("Voer een geldig postcode");
            }  

            return isValid;
        }
    }
}
