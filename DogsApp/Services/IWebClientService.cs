using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DogsApp.Services
{
    public interface IWebClientService
    {
        Task<string> GetString(string uri);
    }
}
