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
        public static By txt_City = By.Id("city-control");
       public static By txt_SelectCity = By.XPath("//*[@id='modal-select-city']/div/div/div[2]/form/div[1]/div/div[2]/ul/li[3]");

        public static By txt_Area = By.Id("area-control");
        public static By txt_SelectArea = By.XPath("//*[@id='modal-select-city']/div/div/div[2]/form/div[2]/div/div[2]/div/input");

        public static By btn_Select = By.CssSelector("#modal-select-city > div > div > div.modal-body > form > button");



    }

}
