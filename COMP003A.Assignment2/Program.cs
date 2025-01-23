namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userFirstName;
            string userLastName;
            int userAge;
            int futureAge;
            double itemPrice;
            double itemDiscountStudent;
            double itemDiscountSenior;
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
            futureAge = userAge + 5;

            Console.Write("What is the price of the item you're interested in?: ");
            itemPrice = double.Parse(Console.ReadLine());
            itemDiscountStudent = itemPrice * .9;
            itemDiscountSenior = itemPrice * .8;

            Console.Write("Are you a student? (true/false): ");
            student = bool.Parse(Console.ReadLine());

            // Output Section
            Console.Write(
                "\n\n\n" +
                "******************************************\n" +
                $"Hello, {userFirstName} {userLastName}!\n" +
                $"Your current age is {userAge}.\n" +
                $"In 5 years, you will be {futureAge}.\n" +
                $"The original price of the item is ${itemPrice}.\n" +
                $"As a student, your discounted price is ${itemDiscountStudent}.\n" +
                $"As a senior, your discounted price is ${itemDiscountSenior}.\n" +
                "******************************************\n");
        }

    }
    }
