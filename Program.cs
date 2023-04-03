namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Page");
            ValidMobileNumber Mobilenumber = new ValidMobileNumber();
            Console.WriteLine("Please enter the mobile number:");
            String mobilNumber= Console.ReadLine();
            Console.WriteLine(Mobilenumber.ValidatMoNumber(mobilNumber));
        }
    }
}