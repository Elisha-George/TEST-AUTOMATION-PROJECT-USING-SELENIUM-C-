using NUnit.Framework;
using ST_SemesterProject_2022;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Tests;

namespace ST_SemesterProject_2022
{
    [TestFixture]
    public partial class ValidSelectLocationTestCases : NUnitAttributes
    {
        [Test]
      //  [Category("SelectLocationFunctionality"), Category("SoftwareTesting")]
        [Author("Unzila")]
        public void ValidLocation()
        {

            LocationPage.Area = "Chota Gate, Malir";

            LocationPage.SelectLocation();

        }
    }
}
