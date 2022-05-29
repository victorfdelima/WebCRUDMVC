using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAdv.Services
{
    public interface IAuthenticate
    {
        Task<bool> Authenticate(string Email, string Password);
        Task Logout();
    }
}