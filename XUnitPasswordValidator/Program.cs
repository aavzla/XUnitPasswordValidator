using System;

namespace XUnitPasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This application will test if your password is valid accorging to the rules to meet:");
            Console.WriteLine("* The password must have at least 8 characters.");
            Console.WriteLine("* The password must have at least 1 UpperCase character.");
            var passwordValidator = new PasswordValidator();
            bool isValid = false;
            do
            {
                Console.WriteLine("Please write your password.");
                var password = Console.ReadLine();
                if (passwordValidator.Validate(password))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("The password submitted is not valid.");
                }

            } while (!isValid);
            Console.WriteLine("The password submitted is valid.");
            Console.WriteLine("To exit, please press any key.");
            Console.ReadKey();
        }
    }
}
