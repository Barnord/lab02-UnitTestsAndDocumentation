using System;

namespace lab02_UnitTestsAndDocumentation
{
    class Program
    {
        static public decimal Balance = 100.00M;

        static void Main(string[] args)
        {
            UserInterface();
        }

        public static void UserInterface()
        {
            Console.WriteLine("Welcome to the ATM");
            Console.WriteLine("Please choose to Deposit, Withdraw, or View your balance with the corresponding word.");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "deposit":
                    Console.WriteLine("How much would you like to deposit?");
                    Deposit(Convert.ToDecimal(Console.ReadLine()));
                    break;
                case "withdraw":
                    Console.WriteLine("How much would you like to withdraw?");
                    Withdraw(Convert.ToDecimal(Console.ReadLine()));
                    break;
                case "view":
                    Console.WriteLine($"Your ballance is {ViewBalance()}");
                    break;
                default:
                    Console.WriteLine("Please enter a valid input.");
                    break;
            }
            UserInterface();
        }

        public static decimal Withdraw(decimal withdrawal)
        {
            return Balance -= withdrawal;
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
