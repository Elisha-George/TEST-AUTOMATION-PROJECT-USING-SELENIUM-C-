using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Tests;

namespace ST_SemesterProject_2022
{
    [TestFixture]
    public partial class RegistrationTestCases : NUnitAttributes
    {
        [Test]
        [Category("Registration"), Category("SoftwareTesting")]
        [Author("Unzila")]
        public void ValidRegistration()
        {
            RegistartionPage.Fullname = "Unzila";
            RegistartionPage.Email = "fa19bsse0004@maju.edu.pk";
            RegistartionPage.MobileNumber = "3222123812";
            RegistartionPage.Password = "aliznu1234";
            RegistartionPage.ConfirmPassword = "aliznu1234";
            RegistartionPage.Registration();
           // string ExpectedOutcome = driver.FindElement(By.XPath("/html/body/main/div/div[1]/div/div/div[2]")).Text;
           // Assert.AreEqual(ExpectedOutcome, "A user with this phone number already exists, please use another phone number and try again.");
        }
    }
}
