﻿using ShoppingApp.WebModels_.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Services.Interfaces
{
    public interface IUserService
    {
        void Register(RegisterViewModel registerModel);
        void Login(LoginViewModel loginModel);
        void Logout();
        UserViewModel GetCurrentUser(string username);
    }
}
