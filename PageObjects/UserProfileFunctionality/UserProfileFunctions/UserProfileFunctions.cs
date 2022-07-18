using NUnit.Framework;
using ST_SemesterProject_2022;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Tests;

namespace ST_SemesterProject_2022
{
    public partial class UserProfilePage : NUnitAttributes
    {
        public static void UserProfile()
        {
            driver.FindElement(btn_profile).Click();
            driver.FindElement(btn_myAccount).Click();
            driver.FindElement(btn_MyOrder).Click();

          
        }
    }
}

