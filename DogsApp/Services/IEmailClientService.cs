using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DogsApp.Services
{
    public interface IEmailClientService
    {
        Task<bool> SendEmail(string To, string From, string Subject, string Body);
    }
}
