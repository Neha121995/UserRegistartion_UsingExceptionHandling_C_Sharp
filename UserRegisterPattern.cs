using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration_ExceptionHandling
{
    public class UserRegisterPattern
    {
        public static String Regex_mobileNumber = "(0|91)?[ ][6-9][0-9]{9}";
        public bool validateMobileNumber(string mobileNo)
        {
            if (mobileNo == null)
            {
                throw new UserRegistrationClass(UserRegistrationClass.ExceptionsType.Invalid_MESSAGE, "Entered Invalid Mobile Number");
            }
            return Regex.IsMatch(mobileNo, Regex_mobileNumber);
        }

    }
}
