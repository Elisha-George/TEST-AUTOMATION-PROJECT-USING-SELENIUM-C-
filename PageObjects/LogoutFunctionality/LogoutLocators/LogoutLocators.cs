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
        public static By btn_MenuButton = By.XPath("//*[@id='dropdownMenuButton']");
        public static By btn_Logout = By.XPath("/html/body/header/div/div/div/nav/div[1]/div/div/div/a[2]");
      

    }
}
