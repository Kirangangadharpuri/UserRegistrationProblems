namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Page");
            PasswordRule1 Password = new PasswordRule1();
            Console.WriteLine("Please enter password:");
            string passWord = Console.ReadLine();
            Console.WriteLine(Password.ValidatePassword(passWord));
        }
    }
}