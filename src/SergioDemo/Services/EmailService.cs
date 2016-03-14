using SergioDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SergioDemo.Services
{
    public class EmailService : IEmailService
    {
        public bool SendEmail(string to, string from, string subject, string body)
        {
            Debug.WriteLine($"Sending Email to {to}, Subject {subject}, From {from}");
            return true;
        }
    }
}
