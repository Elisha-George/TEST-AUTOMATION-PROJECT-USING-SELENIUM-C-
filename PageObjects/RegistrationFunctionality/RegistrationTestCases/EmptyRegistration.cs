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
        public void EmptyRegistration()
        {
            RegistartionPage.Fullname = " ";
            RegistartionPage.Email = " ";
            RegistartionPage.MobileNumber = " ";
            RegistartionPage.Password = " ";
            RegistartionPage.ConfirmPassword = " ";
            RegistartionPage.Registration();
            
          //  string ExpectedOutcome = driver.FindElement(By.XPath("//*[@id='confirm - password']")).Text;
          //  Assert.AreEqual(ExpectedOutcome, "Please fill in this field.");

        }
    }
}
