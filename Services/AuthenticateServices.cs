using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CrudAdv.Services
{
    public class AuthenticateServices : IAuthenticate
    {
        private readonly SignInManager<IdentityUser> _signInManager;


        public AuthenticateServices(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }
        public async Task<bool> Authenticate(string Email, string Password)
        {
            var result = await _signInManager.PasswordSignInAsync(Email, Password, false, lockoutOnFailure: false);
            return result.Succeeded;
        }

        public async Task Logout()
        {
            await _signInManager.SignOutAsync();

        }
    }
}