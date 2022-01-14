using B_Darbas.Page;
using B_Darbas.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Darbas.Tests
{
    class TestBase
    {
        protected static IWebDriver Driver;

        public static ReservedPage reservedPage;



        [OneTimeSetUp]
        public static void Setup()
        {
            reservedPage = new ReservedPage(Driver);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Driver.Quit();
        }

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.TakeScreenshot(Driver);
            }

        }
    }
}
