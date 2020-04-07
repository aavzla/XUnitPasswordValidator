using Xunit;

namespace XUnitPasswordValidator.Test
{
    public class PasswordValidatorTests
    {
        [Fact]
        public void Validate_GivenLongerThan8Chars_ReturnsTrue()
        {
            var passwordValidator = new PasswordValidator();
            var password = "12345678a";
            var isValid = passwordValidator.Validate(password);

            Assert.True(isValid);
        }

        [Fact]
        public void Validate_GivenShorterThan8Chars_ReturnsFalse()
        {
            var passwordValidator = new PasswordValidator();
            var password = "123456a";
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
        public void Validate_GivenAlphaNumericPassword_ReturnsTrue()
        {
            var passwordValidator = new PasswordValidator();
            var password = "12345678A";
            var isValid = passwordValidator.Validate(password);

            Assert.True(isValid);
        }

        [Fact]
        public void Validate_GivenNonAlphaNumericPassword_ReturnsFalse()
        {
            var passwordValidator = new PasswordValidator();
            var password = "!#$%^&*()";
            var isValid = passwordValidator.Validate(password);

            Assert.False(isValid);
        }
    }
}
