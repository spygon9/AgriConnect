﻿using AgriConnect.Shared;
using Microsoft.AspNetCore.Identity;

namespace AgriConnect.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserAsync(string email);
        Task<IdentityResult> AddUserAsync(User user, string password);
        Task CheckRoleAsync(string roleName);
        Task AddUserToRoleAsync(User user, string roleName);
        Task<bool> IsUserInRoleAsync(User user, string roleName);
        //Task<SignInResult> LoginAsync(LoginDTO login);
        Task LogoutAsync();
    }
}
