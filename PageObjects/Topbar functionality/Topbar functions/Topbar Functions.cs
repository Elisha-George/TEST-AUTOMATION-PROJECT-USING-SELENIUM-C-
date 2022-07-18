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


        public static void click_topbar()
        {

            driver.FindElement(btn_ChangeLocation).Click();
            driver.FindElement(img_logo).Click();
            driver.FindElement(bnt_loginSignup).Click();
            driver.FindElement(btn_phone).Click();
            driver.FindElement(btn_Cart).Click();

        }
    }
}
