namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Page");
            ValidEmail eMail = new ValidEmail();
            Console.WriteLine("Please enter the email:");
            string email=Console.ReadLine();
            Console.WriteLine(eMail.validateEmail(email));
        }
    }
}