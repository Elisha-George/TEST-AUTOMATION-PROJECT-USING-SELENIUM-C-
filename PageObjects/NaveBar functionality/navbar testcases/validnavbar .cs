using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Tests;

namespace ST_SemesterProject_2022
{
    [TestFixture]
    public partial class NavBarTestCases : NUnitAttributes
    {
        [Test]
        [Category("NavBar"), Category("SoftwareTesting")]
        [Author("Elisha")]
        public void ValidNavBar()
        {


            NavBar.Click_navbar();
        }
    }
}
