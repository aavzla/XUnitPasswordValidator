using Xunit;

namespace XUnitPasswordValidator.Test
{
    public class PasswordValidatorTests
    {
        [Fact]
        public void Validate_GivenLongerThan8Chars_ReturnsTrue()
        {
            var passwordValidator = new PasswordValidator();
            var password = "12345678A";
            var isValid = passwordValidator.Validate(password);

            Assert.True(isValid);
        }

        [Fact]
        public void Validate_GivenShorterThan8Chars_ReturnsFalse()
        {
            var passwordValidator = new PasswordValidator();
            var password = "123456A";
            var isValid = passwordValidator.Validate(password);

            Assert.False(isValid);
        }

        [Fact]
        public void Validate_GivenPasswordWithUpperCase_ReturnsTrue()
        {
            var passwordValidator = new PasswordValidator();
            var password = "12345678A";
            var isValid = passwordValidator.Validate(password);

            Assert.True(isValid);
        }

        [Fact]
        public void Validate_GivenPasswordWithOutUpperCase_ReturnsFalse()
        {
            var passwordValidator = new PasswordValidator();
            var password = "12345678a";
            var isValid = passwordValidator.Validate(password);

            Assert.False(isValid);
        }

        [Fact]
        public void Validate_GivenPasswordWithDigit_ReturnsTrue()
        {
            var passwordValidator = new PasswordValidator();
            var password = "1ABCDEFGHI";
            var isValid = passwordValidator.Validate(password);

            Assert.True(isValid);
        }

        [Fact]
        public void Validate_GivenPasswordWithOutDigit_ReturnsFalse()
        {
            var passwordValidator = new PasswordValidator();
            var password = "ABCDEFGHI";
            var isValid = passwordValidator.Validate(password);

            Assert.False(isValid);
        }
    }
}
