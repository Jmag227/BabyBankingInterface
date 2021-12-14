using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           Deposit(Greet());





        }

        public static string Greet()
        {
            Console.WriteLine("Hello, Welcome to Magalei Banking Mobile!");
            Console.WriteLine();
            Console.WriteLine("Please enter your name.");
            Console.WriteLine();
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, thank you for choosing MBM!");
            Console.WriteLine();
            return name;
        }

        public static void Deposit(string name)
        {
            Console.WriteLine();
            bool didParse;
            double y;
            Console.WriteLine("Please enter the amount you would like to donate.. er, deposite!");

            do
            {
                didParse = double.TryParse(Console.ReadLine(), out double x);
                y = x;
                if(didParse == false)
                {
                    Console.WriteLine("That is not a valid number, try again");
                } 
                   
            } while (!didParse);

            var depo = new BankAccount();
            depo.Deposit(y);
            Console.WriteLine();

            var num = depo.GetBalance();
            Console.WriteLine($"Your new Balance is {num}");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();                         
        }

        public static void LeaveOrNO()
        {
            Console.WriteLine("Would you like or make another deposite?");
        }



    }
}
