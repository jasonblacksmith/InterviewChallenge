using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace InterviewChallenge_JRW.QA.UITests
{
    public class UIHelpers
    {
        public bool IsElementVisible(IWebElement webElement)
        {
            if (webElement.Displayed) 
            {
                return true;
            }
            return false;
        }
    }
}
