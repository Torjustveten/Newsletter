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
        private IEmailService _emailService;
        public SubscriptionService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        
        public async Task Subscribe(Subscription subscription)
        {
            var vertificationCode = new Guid().ToString();
            var text = $"<a href="http://localhost:50518/subscription?email={subscription.Email}&code={vertificationCode}\\"> Click here to confirm subscription</a>";
            var email = new Email(
                subscription.Email,
                "Fjong@mail.com",
                "Confirmation of subscription to newsletter",
                text);
            _emailService.Send(email);
        }

        public async Task Verify(Verification verification)
        {
            
        }
    }

    
}
