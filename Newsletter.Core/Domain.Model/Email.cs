using System;
using System.Collections.Generic;
using System.Text;

namespace Newsletter.Core.Domain.Model
{
    public class Email
    {
        private string To { get; set; }
        private string From { get; set; }
        private string Subject { get; set; }
        private string Text { get; set; }
    }
}
