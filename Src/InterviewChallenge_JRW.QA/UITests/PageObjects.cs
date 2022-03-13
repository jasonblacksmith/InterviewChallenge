using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace InterviewChallenge_JRW.QA.UITests
{
    public class PageObjects : UI_TestBase
    {
        //public IWebElement A => Driver.FindElement(By.XPath(""));
        #region WebElements
        //HOME PAGE
        //Page Title or Header
        public IWebElement PageHeader => Driver.FindElement(By.XPath("//a[text()=\"Interview Challenge App\"]"));
        //LeftNav Home
        public IWebElement Home => Driver.FindElement(By.XPath("//a[contains(text(), \"Home\")]"));
        //LeftNav Counter
        public IWebElement Counter => Driver.FindElement(By.XPath("//a[contains(text(), \"Counter\")]"));
        //LeftNav Fetch Data
        public IWebElement FetchData => Driver.FindElement(By.XPath("//a[contains(text(), \"Fetch data\")]"));
        //about
        public IWebElement About => Driver.FindElement(By.XPath("//a[contains(text(), \"About\")]"));
        //Content header
        public IWebElement HelloYall => Driver.FindElement(By.XPath("//h1[contains(text(), \"Hello, world!\")]"));
        //Content Survery
        public IWebElement Survey => Driver.FindElement(By.XPath("//a[contains(text(), \"brief survey\")]"));

        //COUNTER PAGE Content Header
        public IWebElement CounterH1 => Driver.FindElement(By.XPath("//h1[contains(text(), \"Counter\")]"));
        //Counter count
        public IWebElement CounterNum => Driver.FindElement(By.XPath("//p[@role='status']/text()[2]"));
        //Counter Button
        public IWebElement CounterButton => Driver.FindElement(By.XPath("//button[contains(text(), \"Click me\")]"));

        //FETCH DATA PAGE ~ is horribly broken... :( Breaks the site when visited
        public IWebElement WeatherForecastH1 => Driver.FindElement(By.XPath("//h1[contains(text(), \"Weather forecast\")]"));//Breaks the site when visited
        #endregion
    }
}
