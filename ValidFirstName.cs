using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class ValidFirstName
    {
        public static string FirstName = "^[A-Z]{1}[A-Za-z]{3,}$";
        public bool ValidateFirstName(string FName)
        {
            return Regex.IsMatch(FName, FirstName);
        }
    }
}
