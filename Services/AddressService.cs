using System;

namespace SingleResponsibilityPrinciple
{
    public class AddressService
    {
        public void ChangeAddress(Guid accountId, decimal amount) => System.Console.WriteLine("Address Changed");
    }
}