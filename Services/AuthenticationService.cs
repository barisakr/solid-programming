using System;

namespace SingleResponsibilityPrinciple
{
    public class AuthenticationService
    {
        public void ChangePassword(Guid accountId, string password) => System.Console.WriteLine($" Password changed to {password}");

        public void Login(string username, string password) => System.Console.WriteLine($"{username} tried to log in");
        public void LogOff(string username, string password) => System.Console.WriteLine($"{username} tried to log off");
    }
}