﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversitySystemGreyHat.Gateway;
using UniversitySystemGreyHat.Models;

namespace UniversitySystemGreyHat.Manager
{
    public class LoginManager
    {
        private LoginGateway loginGateway;

        public LoginManager()
        {
            loginGateway=new LoginGateway();
        }
        public string IsUserValid(Login login)
        {
            bool isValid = loginGateway.IsUserValid(login);
            if (isValid)
            {
                return "Login Succesful";
            }
            else
            {
                return "Incorrect Username or Password";
            }
        }
    }
}