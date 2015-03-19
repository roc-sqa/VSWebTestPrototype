using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebTestProto.PageObjects
{
    class GooglePage
    {
        [FindsBy(How = How.Id, Using = "lst-ib")]
        public IWebElement txtSearchBox { get; set; }

        [FindsBy(How = How.Name, Using = "btnK")]
        public IWebElement bttnSearch { get; set; }

        public void EnterSearchText(string searchText)
        {
            txtSearchBox.SendKeys(searchText);
        }
    }
}
