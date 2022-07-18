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

        public static By btn_profile = By.XPath("//*[@id='dropdownMenuButton']");
        public static By btn_myAccount = By.XPath("/html/body/header/div/div/div/nav/div[1]/div/div/div/a[1]");
        public static By btn_MyOrder = By.XPath("/html/body/main/section/div/div/div[1]/section/div/nav/a[1]");

    }

}


