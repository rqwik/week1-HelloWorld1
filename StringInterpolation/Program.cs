using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's u first name?");
            string userFirstName = Console.ReadLine();
            Console.WriteLine("What's u last name?");
            string userLastName = Console.ReadLine();

            Console.WriteLine($"Hello, {userFirstName} {userLastName}!");//string interpolation - $ означает, что используем данные из переменных
                                                                         //userfirstname and userlastname
        }
    }
}
