using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.UI
{
    public  class AppScreen
    {
       public static void Welcome()
        {
            Console.Clear();
            Console.Title = "My ATM inc.";
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n\n---------------- Welcome to My ATM inc. ----------------\n\n");


            Console.WriteLine("Please insert your ATM card");
            Console.WriteLine("Note: Actual ATM machine will accept and validate a physical ATM card, read the card number and validate it.");

            Utility.PressEnterToContinue();
        }



        
        
    }
}
