using System;
using XUnitPasswordValidator.Interfaces;

namespace XUnitPasswordValidator
{
    public class PasswordValidator : IPasswordValidator
    {
        public bool Validate(string password)
        {
            /*
             * The acceptance criteria is that the password:
             * Must have at least 8 characters.
             * Must have at least 1 UpperCase character.
             */

            throw new NotImplementedException();
        }
    }
}
