using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration_ExceptionHandling
{
    public class UserRegisterPattern
    {
        public static String Regex_LName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool validateLastName(string LName)
        {
            if (LName == null)
            {
                throw new UserRegistrationClass(UserRegistrationClass.ExceptionsType.Invalid_MESSAGE, "Entered Invalid Last Name");
            }
            return Regex.IsMatch(LName, Regex_LName);
        }

        internal string validateLastN(string LName)
        {
            throw new NotImplementedException();
        }
    }
}
