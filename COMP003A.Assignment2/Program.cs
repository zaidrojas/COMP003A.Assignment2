namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userFirstName;
            string userLastName;
            int userAge;
            int itemPrice;
            bool student;

            Console.Write(
                "******************************************\n" +
                "Welcome to the Discount Calculator!\n" +
                "******************************************\n" +
                "What is your first name?: ");
            userFirstName = Console.ReadLine();

            Console.Write("What is your last name?: ");
            userLastName = Console.ReadLine();

            Console.Write("How old are you?: ");
            userAge = int.Parse(Console.ReadLine());

            Console.Write("What is the price of the item you're interested in?: ");
            itemPrice = int.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true/false): ");
            student = bool.Parse(Console.ReadLine());

            Console.Write(
            "\n\n\n" +
            "******************************************\n" +
            $"Hello {userFirstName} {userLastName}\n" +
            $""+
            $"" +
            $"" +
            $"" +
            $"");

        }
    }
}
