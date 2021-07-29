using System;

namespace UserRegistration_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registartion Problem Using Exception Handling");
            UserRegisterPattern UserRegisterPattern = new UserRegisterPattern();

            Console.Write("Enter FirstName: ");
            string FName = Console.ReadLine();
            Console.WriteLine("The test result :: " + UserRegisterPattern.validateFirstName(FName));

        }
        
    }
}
