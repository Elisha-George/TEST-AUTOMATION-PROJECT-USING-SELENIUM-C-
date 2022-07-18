using NUnit.Framework;
using ST_SemesterProject_2022;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Tests;

namespace ST_SemesterProject_2022
{
    public partial class LoginPage : NUnitAttributes
    {
        

        public static string Email { get; set; }
        public static string password { get; set; }

        public static void Login()
        {
            if (Email != null)
            {
                
                driver.FindElement(txt_Username).SendKeys(Email);
            }
            if (password != null)
            {
                driver.FindElement(txt_Password).Clear();
                driver.FindElement(txt_Password).SendKeys(password);
            }

            driver.FindElement(btn_Login).Click();
        }
    }
}
