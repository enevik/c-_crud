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

        public static bool checkForCellPhone(String cellPhoneNumber)
        {
            bool isValid = false;
            Regex regex = new Regex(@"^((\+31)|(0031)|0)(\(0\)|)(\d{1,3})(\s|\-|)(\d{8}|\d{4}\s\d{4}|\d{2}\s\d{2}\s\d{2}\s\d{2})$");
            if (regex.IsMatch(cellPhoneNumber))
            {
                isValid = true;
            }
            else
            {
                MessageBox.Show("Voer een geldig nummer");
            }

            return isValid;
        }
    }
}
