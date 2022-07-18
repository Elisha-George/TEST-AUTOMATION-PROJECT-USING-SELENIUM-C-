using NUnit.Framework;
using ST_SemesterProject_2022;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Tests;

namespace ST_SemesterProject_2022
{
    public partial class TopBar : NUnitAttributes
    {

        public static By btn_ChangeLocation = By.XPath("/html/body/header/div/div/div/nav/a[1]");
        public static By img_logo = By.XPath("/html/body/header/div/div/div/nav/a[2]/img");
        public static By bnt_loginSignup = By.XPath("/html/body/header/div/div/div/nav/div[1]/a");
        public static By btn_phone = By.XPath("/html/body/header/div/div/div/nav/div[3]/p");
        public static By btn_Cart = By.XPath("/html/body/main/section/button");


    }

}

