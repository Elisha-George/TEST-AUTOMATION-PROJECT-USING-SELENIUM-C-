using NUnit.Framework;
using ST_SemesterProject_2022;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Tests;

namespace ST_SemesterProject_2022
{
    public partial class NavBar : NUnitAttributes
    {


        public static void Click_navbar()
        {

            driver.FindElement(btn_promoDeals).Click();
            driver.FindElement(btn_maxValueDeals).Click();
            driver.FindElement(btn_BigandBetter).Click();
            driver.FindElement(btn_Apitizers).Click();
            driver.FindElement(btn_pasta).Click();
            driver.FindElement(btn_MaxPlatter).Click();
            driver.FindElement(btn_SandWitch).Click();
            driver.FindElement(btn_ClassicPizza).Click();
            driver.FindElement(btn_Beaverages).Click();
            driver.FindElement(btn_SignaturePizza).Click();

        }
    }
}
