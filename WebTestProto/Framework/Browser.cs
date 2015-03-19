using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebTestProto.Framework
{
    public static class Browser
    {
        static IWebDriver webDriver;

        public static ISearchContext Driver { get { return webDriver; } }

        public static void SetDriver()
        {
            webDriver = new FirefoxDriver();
        }

        public static void Goto(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
            webDriver.Close();
        }

        public static void Quit()
        {
            webDriver.Quit();
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static void MaximizeWindow()
        {
            webDriver.Manage().Window.Maximize();
        }
    }
}
