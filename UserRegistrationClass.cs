using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration_ExceptionHandling
{
    class UserRegistrationClass : Exception
    {
        public enum ExceptionsType
        {
            Invalid_MESSAGE,
        }
        public ExceptionsType type;
        public UserRegistrationClass(ExceptionsType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
