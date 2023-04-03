using System.Runtime.InteropServices;

namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Page");
            ValidLastName name = new ValidLastName();
            Console.WriteLine("Enter Last Name");
            string LName = Console.ReadLine();
            Console.WriteLine(name.ValidateLastName(LName));
        }
    }
}