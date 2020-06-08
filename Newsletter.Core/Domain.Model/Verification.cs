using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Text;

namespace Newsletter.Core.Domain.Model
{
    public class Verification
    {
        public string Email { get; set; }
        public string VerificationCode { get; set; }
    }
}
