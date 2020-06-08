using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newsletter.Core.Domain.Model;
using Newsletter.Core.Domain.Service;

namespace Newsletter.Core.Application.Service
{
    public class SubscriptionService
    {
        private readonly IEmailService _emailService;
        public SubscriptionService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        
        public async Task Subscribe(Subscription subscription)
        {
            var vertificationCode = new Guid().ToString();
            var url = $"http://localhost:50518/subscription?email={subscription.Email}&code={subscription.VerificationCode}";
            var text = $"<a href=\"{url}\">Click here to confirm!</a>";
            var email = new Email(
                subscription.Email,
                "FjongOgFin@mail.com",
                "Confirmation of subscription to newsletter",
                text);
            await _emailService.Send(email);
        }

        public async Task Verify(Subscription verificationCode)
        {
            
        }
    }

    
}
