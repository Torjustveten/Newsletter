using System;
using System.Collections.Generic;
using System.Text;

namespace Newsletter.Core.Domain.Model
{
    public class Subscription
    {
        public Subscription(string name, string email, string verificationCode)
        {
            Name = name;
            Email = email;
            VerificationCode = verificationCode ?? Guid.NewGuid().ToString();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string VerificationCode { get; set; }
        public bool IsVerified { get; set; }

    }
}
