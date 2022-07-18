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
        public static string Fullname { get; set; }
        public static string Email { get; set; }

        public static string MobileNumber { get; set; }
        public static string Password { get; set; }

        public static string ConfirmPassword { get; set; }

        public static void Registration()
        {

            driver.FindElement(Link_Registration).Click();

            if (Fullname != null)
            {

                driver.FindElement(txt_Fullname).SendKeys(Fullname);
            }
            if (Email != null)
            {

                driver.FindElement(txt_Email).SendKeys(Email);
            }
            if (MobileNumber != null)
            {

                driver.FindElement(txt_Number).SendKeys(MobileNumber);
            }
            if (Password != null)
            {

                driver.FindElement(txt_Password).SendKeys(Password);
            }
            if (ConfirmPassword != null)
            {

                driver.FindElement(txt_ConfirmPassword).SendKeys(ConfirmPassword);
            }

            driver.FindElement(btn_Register).Click();
        }
    }
}

