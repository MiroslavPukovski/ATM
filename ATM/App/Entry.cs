using ATM.UI;
using ATM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.App
{
     class Entry
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            var atmApp = new ATMApp();

            atmApp.CheckUserCardNumberAndPassword();

            Utility.PressEnterToContinue();

        }

    }
}
