using System.Linq;
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
             * Must have at least 1 digit character.
             */

            if (password.Length < 8 || !(password.Any(x => char.IsUpper(x)) && password.Any(x => char.IsDigit(x))))
            {
                return false;
            }

            return true;
        }
    }
}
