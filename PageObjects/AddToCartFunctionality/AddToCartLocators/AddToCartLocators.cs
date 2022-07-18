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

        public static By btn_AddToCart = By.XPath("/html/body/main/section/button/div");
        public static By Chk_Crust = By.XPath("//*[@id='681909']");
        public static By Chk_Flavour = By.XPath("//*[@id='680313'']");
        public static By btn_cartSave = By.XPath("//*[@id='cartSave']");
        public static By btn_Cart = By.XPath("/html/body/main/section/button");
       

    }

}

