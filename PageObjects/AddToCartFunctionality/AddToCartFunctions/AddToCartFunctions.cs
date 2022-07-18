using NUnit.Framework;
using ST_SemesterProject_2022;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Tests;

namespace ST_SemesterProject_2022
{
    public partial class AddToCartPage : NUnitAttributes
    {


        public static void AddtoCart()
        {

            driver.FindElement(btn_AddToCart).Click();
            driver.FindElement(Chk_Crust).Click();
            driver.FindElement(Chk_Flavour).Click();
            driver.FindElement(btn_cartSave).Click();
            driver.FindElement(btn_Cart).Click();

    }
    }
}
