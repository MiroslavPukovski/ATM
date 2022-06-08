using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.UI
{
    public class Utility
    {
        public static void PressEnterToContinue()
        {
            Console.WriteLine("\n\nPress Enter to constinue...\n");
            Console.ReadLine();
        }

        public static string GetUserInput(string prompt)
        {
            Console.WriteLine($"Enter {prompt}");
            return Console.ReadLine();
        }

    }
}
