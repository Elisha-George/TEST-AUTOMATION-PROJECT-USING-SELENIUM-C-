using NUnit.Framework;
using ST_SemesterProject_2022;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Tests;

namespace ST_SemesterProject_2022
{
    public partial class RegistartionPage : NUnitAttributes
    {
        public static By Link_Registration = By.XPath("/html/body/header/div/div/div/nav/div[1]/a");
        public static By txt_Fullname = By.Id("fullname");
        public static By txt_Email = By.XPath("email");
        public static By txt_Number = By.XPath("mobile-number");
        public static By txt_Password = By.XPath("(//*[@id='password'])[2]");
        public static By txt_ConfirmPassword = By.Id("confirm-password");
        public static By btn_Register = By.Id("registerBtn");

    }

}

