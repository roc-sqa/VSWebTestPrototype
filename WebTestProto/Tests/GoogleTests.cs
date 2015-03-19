using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebTestProto.PageObjects;
using WebTestProto.Framework;

namespace WebTestProto.Tests
{
    [TestClass]
    public class GoogleTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Browser.SetDriver();
            Browser.Goto("http://www.google.com");
            Pages.GooglePage.EnterSearchText("testing");
        }
    }
}
