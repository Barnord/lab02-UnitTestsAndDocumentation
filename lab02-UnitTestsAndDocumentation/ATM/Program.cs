using System;

namespace ATM
{
    public class Program
    {
        static public decimal Balance = 100.00M;

        public static void Main(string[] args)
        {
            UserInterface();
        }

        public static void UserInterface()
        {
            Console.WriteLine("Welcome to the ATM");
            Console.WriteLine("Please choose to Deposit, Withdraw, or View your balance with the corresponding word.");
            string input = Console.ReadLine();

            try
            {
                switch (input.ToLower())
                {
                    case "deposit":
                        Console.WriteLine("How much would you like to deposit?");
                        Deposit(Convert.ToDecimal(Console.ReadLine()));
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    case "withdraw":
                        Console.WriteLine("How much would you like to withdraw?");
                        Withdraw(Convert.ToDecimal(Console.ReadLine()));
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    case "view":
                        Console.WriteLine($"Your ballance is {ViewBalance()}");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input.");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                Console.Clear();
                Console.WriteLine("Would you like to make another transaction? (y/n)");
                string transaction = Console.ReadLine().ToLower();
                if (transaction == "y" || transaction == "yes" || transaction == "yeah")
                {
                    UserInterface();
                }
            }
        }

        public static decimal Withdraw(decimal withdrawal)
        {

            if ((Balance - withdrawal) > 0)
            {
                return Balance -= withdrawal;
            }
            else
            {
                throw new Exception("You cannot overdraw your account!");
            }

        }

        public static decimal ViewBalance()
        {
            return Balance;
        }

        public static decimal Deposit(decimal deposit)
        {
            return Balance += deposit;
        }
    }
}
