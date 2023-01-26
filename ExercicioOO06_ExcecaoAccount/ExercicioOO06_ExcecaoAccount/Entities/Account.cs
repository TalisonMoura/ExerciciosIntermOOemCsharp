using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioOO06_ExcecaoAccount.Entities.Exceptions;

namespace ExercicioOO06_ExcecaoAccount.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimt { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withDrawLimt)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimt = withDrawLimt;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void WithDraw(double amount)
        {
            if (amount > WithDrawLimt)
            {
                throw new DomainException("The amount exceeds withdraw limit!");
            }
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance!");
            }

            Balance -= amount;

        }
    }
}
