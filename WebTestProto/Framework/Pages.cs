using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WebTestProto.PageObjects;

namespace WebTestProto.Framework
{
    class Pages
    {
        public static GooglePage GooglePage
        {
            get
            {
                var googlePage = new GooglePage();
                PageFactory.InitElements(Browser.Driver, googlePage);
                return googlePage;
            }
        }
    }
}
