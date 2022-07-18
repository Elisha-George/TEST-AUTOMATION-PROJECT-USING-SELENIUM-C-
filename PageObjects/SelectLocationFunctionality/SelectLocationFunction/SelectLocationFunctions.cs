using NUnit.Framework;
using ST_SemesterProject_2022;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Tests;

namespace ST_SemesterProject_2022
{
    public partial class LocationPage : NUnitAttributes
    {


      
        public static string Area { get; set; }

        public static void SelectLocation()
        {

            driver.FindElement(txt_City).Click();
            driver.FindElement(txt_SelectCity).Click();

            driver.FindElement(txt_Area).Click();

            if (Area != null)
            {
              
                driver.FindElement(txt_SelectArea).SendKeys(Area);
            }

            driver.FindElement(btn_Select).Click();
        }
    }
}

