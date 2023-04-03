namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Page");
            PasswordRule3 passWord=new PasswordRule3();
            Console.WriteLine("Please Enter Password:");
            string password = Console.ReadLine();
            Console.WriteLine(passWord.ValidatePassword(password));
        }
    }
}