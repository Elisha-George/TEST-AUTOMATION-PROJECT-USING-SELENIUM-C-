using NUnit.Framework;
using ST_SemesterProject_2022;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Tests;

namespace ST_SemesterProject_2022
{ 
    public partial class LoginPage : NUnitAttributes
{

    public static By txt_Username = By.Id("username");
    public static By txt_Password = By.XPath("(//*[@id='password'])[1]");
    public static By btn_Login = By.XPath("//*[@id='myTabContent']/div[1]/form/button");

}

}


