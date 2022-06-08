using System;
using ATM.UI;



namespace ATMApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            string cardNumber = Utility.GetUserInput("your card number");
            Console.WriteLine($"Your card number is {cardNumber}");

            Utility.PressEnterToContinue();

        }
    }






}



