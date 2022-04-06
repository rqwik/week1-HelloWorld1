using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's u first name?");
            string userFirstName = Console.ReadLine(); //string - тип ячейки памяти для сохранения текста
            Console.WriteLine("What's u last name?");
            string userLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + userFirstName + " " + userLastName + "!");

        }
    }
}
