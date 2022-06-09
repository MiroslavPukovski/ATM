using System;
using ATM.Domain;
using ATM.Domain.Interfaces;
using ATM.UI;



namespace ATM
{
    public class ATMApp : IUserLogin
    {
        private List<UserAccount> userAccountList;
        private UserAccount selectedUserAccount;

        public void InitializeData()
        {
            userAccountList = new List<UserAccount>
            {
                new UserAccount{Id=1, FullName = "Miroslav Pukovski", AccountNumber = 123456, CardNumber = 321321, CardPin = 1234, AccountBalance = 15598.00m,IsLocked=false},
                new UserAccount{Id=2, FullName = "Vardenis Pavardenis", AccountNumber = 147852, CardNumber = 000000, CardPin = 0000, AccountBalance = 15845215.98m,IsLocked=false},
                new UserAccount{Id=3, FullName = "Jon Jonson", AccountNumber = 654321, CardNumber = 111111, CardPin = 1111, AccountBalance = 35569.15m,IsLocked=false}
            };
        }

        public void CheckUserCardNumberAndPassword()
        {
            bool isCorrectLoggin = false;

            var tempUserAccount = new UserAccount();

            tempUserAccount.CardNumber = Validator.Convert<long>("your card number.");
            tempUserAccount.CardPin = Convert.ToInt32(Utility.GetSecretInput("Enter your card PIN"));

        }


    }






}



