namespace ContaCorrenteAP
{
    internal class Program
    {
        public static void CreateAccount()
        {
            Account userAccount1 = new Account();
            userAccount1.name = "Robson";
            userAccount1.password = "1234";
            userAccount1.identifier = "RGK4667JF";
            userAccount1.balance = 1000;
            userAccount1.AccountHistory = new List<string> { };

            userAccount1.Withdrawal(200);
            userAccount1.Deposit(200);
            userAccount1.Deposit(200);
            userAccount1.Withdrawal(200);

            Account userAccount2 = new Account();
            userAccount2.name = "Ricardo";
            userAccount2.password = "56789";
            userAccount2.identifier = "MGT3378IP";
            userAccount2.balance = 1000;
            userAccount2.AccountHistory = new List<string> { };

            userAccount1.TransferTo(userAccount2, 400);
            userAccount1.ShowAccountHistory();
        }


        static void Main(string[] args)
        {
            CreateAccount();
        }
    }
}
