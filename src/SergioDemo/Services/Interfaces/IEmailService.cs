using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SergioDemo.Services.Interfaces
{
    public interface IEmailService
    {
        bool SendEmail(string to, string from, string subject, string body);
    }
}
