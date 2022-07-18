using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Tests;

namespace ST_SemesterProject_2022
{
    [TestFixture]
    public partial class TopBarTestCases : NUnitAttributes
    {
        [Test]
        [Category("TopBar"), Category("SoftwareTesting")]
        [Author("Unzila")]
        public void ValidTopBar()
        {

            TopBar.click_topbar();
        }
    }
}
