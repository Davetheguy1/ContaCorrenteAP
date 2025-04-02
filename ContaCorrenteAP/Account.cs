using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrenteAP
{
    public class Account
    {
        public string name;
        public string password;
        public string identifier;
        public double balance;
        public double limit;
        public List<string> AccountHistory;

        public void Withdrawal(double value)
        {
            balance -= value;
            AccountHistory.Add($"Saque: -R${value}");
        }

        public void Deposit(double value)
        {
            balance += value;
            AccountHistory.Add($"Deposito: +R${value}");
        }

        public void TransferTo(Account userAccount2, double value)
        {
            Withdrawal(value);
            userAccount2.Deposit(value);
            
        }

        public void ShowAccountHistory()
        {
            for (int i = 0; i < AccountHistory.Count; i++)
            {
                Console.WriteLine(AccountHistory[i]);
            }
            Console.WriteLine("Pressione Enter para Sair.\n");
            Console.ReadLine();
        }
    }
}
