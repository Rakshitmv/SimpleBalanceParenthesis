using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBalanceParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CashBalance cashBalance = new CashBalance();
            cashBalance.BalanceCheck();
            Console.ReadLine();
        }
    }
}
