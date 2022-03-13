using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace InterviewChallenge_JRW.QA.UITests
{
    [TestFixture]
    internal class UITests : UI_TestBase
    {
        PageObjects Pom = new();

        [OneTimeSetUp]
        public void setup()
        {
            var uri = new Uri("https://si-interview-app.azurewebsites.net");
            Driver.Navigate().GoToUrl(uri);
        }

        [TestCase, Order(1)] // On Page load the PageHeader is displayed
        public void HomePageLoads()
        {
            var pageHeader = Pom.PageHeader;
            Assert.IsTrue(pageHeader.Displayed);
        }

        [TestCase, Order(2)] // Click Home Button and Home Content is displayed
        public void HomeClick()
        {
            var home = Pom.Home;
            home.Click();
            Assert.IsTrue(Pom.HelloYall.Displayed);
        }

        [TestCase, Order(3)] // Click Counter Button and Counter Content is displayed
        public void CounterNavClick()
        {
            var counterNav = Pom.Counter;
            counterNav.Click();
            Assert.IsTrue(Pom.CounterH1.Displayed);
        }

        [TestCase, Order(4)] // Click the Count Ticker and vaerify increments
        public async void CounterClick()
        {
            //Grab what the number is now
            
            string counterNum = Pom.CounterNum.Text;

            //Click the Counter
            var counterClick = Pom.CounterButton;
            counterClick.Click();

            await Task.Delay(1000);

            ////Grab the new number value
            string counterNum2 = Pom.CounterNum.Text;

            Assert.IsTrue(counterNum != counterNum2);
        }
    }
}
