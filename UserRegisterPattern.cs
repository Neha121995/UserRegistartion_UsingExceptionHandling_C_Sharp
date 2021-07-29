using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration_ExceptionHandling
{
    public class UserRegisterPattern
    {
        public static String Regex_Password = "^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";
        public bool validatePassword(string Pass)
        {
            if (Pass == null)
            {
                throw new UserRegistrationClass(UserRegistrationClass.ExceptionsType.Invalid_MESSAGE, "Entered Invalid Password");
            }
            return Regex.IsMatch(Pass, Regex_Password);
        }

    }
}
