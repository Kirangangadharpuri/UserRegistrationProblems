namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Page");
            PasswordRule2 Password = new PasswordRule2();
            Console.WriteLine("Please enter the password:");
            string password= Console.ReadLine();
            Console.WriteLine(Password.ValidatePassword(password));
        }
    }
}