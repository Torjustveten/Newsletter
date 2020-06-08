using System;
using System.Collections.Generic;
using System.Text;

namespace Newsletter.Core.Domain.Model
{
    public class Subscription
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string VerificationCode { get; set; }
    }
}
