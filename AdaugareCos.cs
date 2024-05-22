using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace AC2024
{
    [TestClass]
    public class AdaugareCos
    {
        private IWebDriver driver;
        [TestMethod]
        public void AdaugaCos()
        {
            /*
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("incognito");
            */
            driver = new ChromeDriver();//options
            driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");

            try
            {
           
                driver.Navigate().GoToUrl("https://www.itgalaxy.ro/");
                driver.Manage().Window.;
             

                //click consent
                driver.FindElement(By.XPath("//button[@aria-label='Accepta']")).Click();

                driver.FindElement(By.Id("uHNac_close")).Click();


                //driver.FindElement(By.LinkText("SSD Extern Samsung T7 Shield 1TB USB 3.2 Blue la Reducere in Super Oferta Momentului! Profita de livrarea rapida, direct din stoc!")).Click();
                //driver.FindElement(By.LinkText("Aspirator robot TESLA VCR600W 0.6L LSD+SLAM White cu -37% reducere! E inca in stoc. Profita si tu!")).Click();
                //driver.FindElement(By.XPath("//div[@id = 'navbar-category']//span[text()='Smartphones, Telefoane & Tablete']")).Click();
                driver.FindElement(By.XPath("//a[@title='Smartphones, Telefoane & Tablete']")).Click();

                //driver.FindElement(By.XPath("//ul[@role='button']//a[@data-url='https://www.itgalaxy.ro/ssd/']")).Click();

                //driver.FindElement(By.XPath("//a[@title='Tablete']")).Click();

                //driver.FindElement(By.XPath("//a[@title='Tablete']")).Click();

                driver.FindElement(By.XPath("//button[@aria-label='Inchide']")).Click();

                //driver.FindElement(By.XPath("//div[@id = 'main-content-wrapper']//span[text()='(424)']")).Click();

                driver.FindElement(By.XPath("//li//a[@title='Tablete']")).Click();

                driver.FindElement(By.XPath("//button[@id='addtocart_button']")).Click();

                driver.FindElement(By.XPath("//a[@data-url='https://www.itgalaxy.ro/trimite-comanda/']")).Click();

                //driver.FindElement(By.CssSelector("a.action.viewcart")).Click();





                Console.WriteLine("Testul s-a încheiat cu succes!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"A apărut o eroare: {ex.Message}");
            }
            finally
            {
                // Închide browser-ul
                //driver.Quit();
            }



        }
       
    }
}
