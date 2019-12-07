// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class SuccesstestABVTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void successtestABV() {
    driver.Navigate().GoToUrl("https://www.abv.bg/");
    driver.Manage().Window.Size = new System.Drawing.Size(1296, 696);
    driver.FindElement(By.Id("username")).SendKeys("d4474813");
    driver.FindElement(By.Id("password")).Click();
    driver.FindElement(By.Id("password")).SendKeys("ioanna88");
    driver.FindElement(By.Id("loginBut")).Click();
    driver.FindElement(By.Id("gwt-uid-406")).Click();
    driver.FindElement(By.Id("gwt-uid-406")).Click();
    driver.FindElement(By.CssSelector(".userName")).Click();
    Assert.That(driver.FindElement(By.CssSelector(".userName")).Text, Is.EqualTo("Unibit 123"));
  }
}
