using System;

namespace SingleResponsibilityPrinciple
{
    public class ProfileService
    {
        public Profile GetProfile(Guid accountId) => new Profile();
    }
}