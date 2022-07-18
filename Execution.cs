using System;
using System.Threading;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace Tests
{
    [TestFixture]
    public class NUnitAttributes
    {
        public static IWebDriver driver;

        public TestContext testContext
        {
            get { return testContext; }
            set { testContext = value; }
        }


        /// <summary>
        /// Executes once for the test class. (Optional)
        /// </summary>
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {

        }

        /// <summary>
        /// Runs before each test. (Optional)
        /// </summary>
        [SetUp]
        public void Setup()
        {
            #region Environment
            Console.WriteLine("Machine : " + Environment.MachineName);
            Console.WriteLine("User Name : " + Environment.UserName);
            Console.WriteLine("OS Version : " + Environment.OSVersion);
            #endregion

            #region Driver Initialization
            

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Url = "https://pizzamax.com.pk/";
            string title = driver.Title;
            Assert.AreEqual(title, "Pizza Max - Online Ordering");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60); //Implicit wait applies to all the web elements in the test script. It is ideal for test scenarios when we are sure that the web elements will be loaded(or visible) within a specified duration
            #endregion
        }

        /// <summary>
        /// Runs after each test. (Optional)
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            //bool abc = TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed;

           // driver.Quit();
        }

        /// <summary>
        /// Runs once after all tests in this class are executed. (Optional)
        /// </summary>
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
        }
    }
}
