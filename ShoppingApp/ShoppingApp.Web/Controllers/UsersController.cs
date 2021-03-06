﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using ShoppingApp.Services.Interfaces;
using ShoppingApp.WebModels_.ViewModels;

namespace ShoppingApp.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _userService;
        private readonly IToastNotification _toastNotification;

        public UsersController(IUserService userService, IToastNotification toastNotification)
        {
            _userService = userService;
            _toastNotification = toastNotification;
        }


        public IActionResult LogIn()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public IActionResult LogIn(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                _userService.Login(model);
                if (User.IsInRole("admin"))
                {
                    _toastNotification.AddSuccessToastMessage("You have successfully loged in!");
                    return RedirectToAction("listallorders", "order");
                }
                _toastNotification.AddSuccessToastMessage("You have successfully loged in!");
                return RedirectToAction("products", "product");
            }
            _toastNotification.AddWarningToastMessage("Username or password are incorect!");
            return View(model);
        }

        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                _userService.Register(model);
                return RedirectToAction("products", "product");
            }
            return View(model);
        }

        public IActionResult LogOut()
        {
            _userService.Logout();
            return RedirectToAction("index", "home");
        }
    }
}