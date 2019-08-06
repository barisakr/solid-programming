using System;

namespace SingleResponsibilityPrinciple
{
    public class AccountService
    {
        public void DepositMoney(Guid accountId, decimal amount) => System.Console.WriteLine($"{amount} has been deposited");

        public void WithdrawMoney(Guid accountId, decimal amount) => System.Console.WriteLine($"{amount} has been withdrawed");
    }
}