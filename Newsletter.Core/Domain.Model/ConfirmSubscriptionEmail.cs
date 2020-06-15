using System;
using System.Collections.Generic;
using System.Text;

namespace Newsletter.Core.Domain.Model
{
    public class ConfirmSubscriptionEmail : Email
    {
        public ConfirmSubscriptionEmail(string to, string from, string code)
            : base(to, from, "Confirmation of subscription to newsletter")
        {
            var baseUrl = "http://localhost:50518/subscription";
            var url = $"{baseUrl}?email={to}&code={code}"; ;
            Text = $"<a href=\"{url}\">Klikk her for å bekrefte</a>"; ;

        }
        
    }
}
