using NUnit.Framework;
using ST_SemesterProject_2022;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Tests;

namespace ST_SemesterProject_2022
{
    public partial class LogoutPage : NUnitAttributes
    {
        public static void Logout()
        {
            driver.FindElement(btn_MenuButton).Click();
            driver.FindElement(btn_Logout).Click();
           
        }
    }
}

