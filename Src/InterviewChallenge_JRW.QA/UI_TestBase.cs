using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace InterviewChallenge_JRW.QA
{
    public class UI_TestBase
    {
        #region GlobalVars
        public static IWebDriver Driver { get; set; }
        
        public static int TimeOutImplicitWaitSecs = 30;
        public static int TimeOutPageLoadSecs = 60;
        #endregion

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {

            Driver = new EdgeDriver();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimeOutImplicitWaitSecs);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(TimeOutPageLoadSecs);
            Driver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
        }

        [OneTimeTearDown]
        public static void CloseBrowser()
        {
            if (Driver != null) 
            { 
                Driver.Close();
            }
        }
    }
}
