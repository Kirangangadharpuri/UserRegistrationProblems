namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Page");
            Console.WriteLine("**********************************************");
            ValidFirstName name = new ValidFirstName();
            Console.WriteLine("Enter the First Name:");
            string FName = Console.ReadLine();
            Console.WriteLine(name.ValidateFirstName(FName));
        }
    }
}