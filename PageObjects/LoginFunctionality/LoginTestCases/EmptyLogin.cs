using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Tests;

namespace ST_SemesterProject_2022
{
    [TestFixture]
    public partial class LoginTestCases : NUnitAttributes
    {
        [Test]
        [Category("Login"), Category("SoftwareTesting")]
        [Author("Unzila")]
        public void EmptyLogin()
        {
            LoginPage.Email = "";
            LoginPage.password = "";

            LoginPage.Login();

        }
    }
}
