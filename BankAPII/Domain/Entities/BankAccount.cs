using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPII.Domain.Entities
{
    public class BankAccount
    {
        // private Client Holder { get; set; }
        public double Balance { get; set; }

        public void Deposit(double value)
        {
            this.Balance += value;
        }

        public void Withdraw(double value)
        {
            if (value <= this.Balance)
            {
                this.Balance -= value;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
        }

        public void Transfer(BankAccount destin, double value)
        {
            if (value <= this.Balance)
            {
                this.Balance -= value;
                destin.Deposit(value);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para transferência.");
            }
        }

        // public virtual void PrintBalance()
        // {
        //     Console.WriteLine($"Saldo da conta de {Holder.Name}: R$ {Balance}");
        // }
    }
}