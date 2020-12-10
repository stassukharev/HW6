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
public class NopCommercesuiteTest {
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
  public void loginwithvalidcredslogout() {
    driver.Navigate().GoToUrl("http://127.0.0.1:8777/");
    driver.Manage().Window.Size = new System.Drawing.Size(1373, 1040);
    {
      var element = driver.FindElement(By.LinkText("Log in"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    driver.FindElement(By.LinkText("Log in")).Click();
    driver.FindElement(By.Id("Email")).SendKeys("admin@userqa.com");
    driver.FindElement(By.Id("Password")).Click();
    driver.FindElement(By.Id("Password")).SendKeys("123456");
    driver.FindElement(By.CssSelector(".login-button")).Click();
    driver.FindElement(By.LinkText("Log out")).Click();
  }
  [Test]
  public void addnokialumiatocard() {
    driver.Navigate().GoToUrl("http://127.0.0.1:8777/");
    driver.Manage().Window.Size = new System.Drawing.Size(1373, 1040);
    driver.FindElement(By.LinkText("Log in")).Click();
    driver.FindElement(By.Id("Email")).SendKeys("admin@userqa.com");
    driver.FindElement(By.Id("Password")).Click();
    driver.FindElement(By.Id("Password")).SendKeys("123456");
    driver.FindElement(By.CssSelector(".login-button")).Click();
    driver.FindElement(By.Id("small-searchterms")).Click();
    driver.FindElement(By.Id("small-searchterms")).SendKeys("Nokia Lumia 1020");
    driver.FindElement(By.CssSelector(".search-box-button")).Click();
    driver.FindElement(By.CssSelector(".product-box-add-to-cart-button")).Click();
    driver.FindElement(By.CssSelector(".cart-label")).Click();
    driver.FindElement(By.LinkText("Log out")).Click();
  }
  [Test]
  public void changequantitygoodsincart() {
    driver.Navigate().GoToUrl("http://127.0.0.1:8777/");
    driver.Manage().Window.Size = new System.Drawing.Size(1373, 1040);
    driver.FindElement(By.LinkText("Log in")).Click();
    driver.FindElement(By.Id("Email")).SendKeys("admin@userqa.com");
    driver.FindElement(By.Id("Password")).Click();
    driver.FindElement(By.Id("Password")).SendKeys("123456");
    driver.FindElement(By.CssSelector(".login-button")).Click();
    {
      var element = driver.FindElement(By.LinkText("Books"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.CssSelector(".cart-label")).Click();
    driver.FindElement(By.Id("itemquantity2")).Click();
    driver.FindElement(By.Id("itemquantity2")).SendKeys("5");
    driver.FindElement(By.Name("updatecart")).Click();
    driver.FindElement(By.LinkText("Log out")).Click();
  }
  [Test]
  public void setuserdata() {
    driver.Navigate().GoToUrl("http://127.0.0.1:8777/");
    driver.Manage().Window.Size = new System.Drawing.Size(1920, 1040);
    driver.FindElement(By.LinkText("Log in")).Click();
    driver.FindElement(By.Id("Email")).SendKeys("admin@userqa.com");
    driver.FindElement(By.Id("Password")).Click();
    driver.FindElement(By.Id("Password")).SendKeys("123456");
    driver.FindElement(By.CssSelector(".login-button")).Click();
    {
      var element = driver.FindElement(By.LinkText("My account"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    driver.FindElement(By.LinkText("My account")).Click();
    driver.FindElement(By.Id("FirstName")).Click();
    driver.FindElement(By.Id("FirstName")).SendKeys("David");
    driver.FindElement(By.CssSelector(".inputs:nth-child(3)")).Click();
    driver.FindElement(By.Id("LastName")).SendKeys("Bowie");
    driver.FindElement(By.Id("Email")).Click();
    driver.FindElement(By.Id("save-info-button")).Click();
    driver.FindElement(By.LinkText("Log out")).Click();
  }
}
