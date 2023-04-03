namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Page");
            PasswordRule4 passWord=new PasswordRule4();
            Console.WriteLine("Please enter password");
            string password=Console.ReadLine();
            Console.WriteLine(passWord.ValidatePassword(password));
        }
    }
}