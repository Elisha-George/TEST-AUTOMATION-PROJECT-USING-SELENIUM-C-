using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Tests;

namespace ST_SemesterProject_2022
{
    [TestFixture]
    public partial class UserProfileTestCases : NUnitAttributes
    {
        [Test]
        [Category("UserProfile"), Category("SoftwareTesting")]
        [Author("Eman")]

        public void ValidUserProfile()
        {

            UserProfilePage.UserProfile();
        }
    }
}
