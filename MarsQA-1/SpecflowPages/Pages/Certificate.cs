using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Certificate : Driver
    {
        // Adding Certificate 
        public static void ClickOnCertificatesTab()
        {
            IWebElement CertificationsButton = driver.FindElement(By.XPath("//a[normalize-space()='Certifications']"));
            CertificationsButton.Click();

        }
                
        public static void ClickOnAddNewButton()
        {
            IWebElement AddNewButton = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
            AddNewButton.Click();

        }

        public static void InputInTextbox(string Award)
        {
            IWebElement AddCertificate = driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
            AddCertificate.SendKeys(Award);

        }

        public static void TypeInBox(string Certifier)
        {
            IWebElement AddCertifier = driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));
            AddCertifier.SendKeys(Certifier);

        }

        public static void SelectFromDropdownList(string Year)
        {
            IWebElement AddYear = driver.FindElement(By.XPath("//select[@name='certificationYear']"));
            AddYear.Click();
            driver.FindElement(By.XPath("//select[@name='certificationYear']"));
            AddYear.SendKeys(Year);

        }

        public static void ClickOnAddButtonToAddCertificate()
        {
            IWebElement AddButton1 = driver.FindElement(By.XPath("//input[@value='Add']"));
            AddButton1.Click();

        }

        public static void CertificateDetailsShouldBeAdded()
        {
            Thread.Sleep(1500);
            String target_xpath = "//div[@class='ns-box-inner']";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));
                        
            String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("has been added to your certification"));

        }

        // Edit Certificate Details
        public static void ClickOnEditButtonNextToCertificateDetailsIWantToEdit()
        {
            IWebElement EditButton1 = driver.FindElement(By.XPath("//tbody/tr/td[4]/span[1]/i[1]"));
            EditButton1.Click();

        }

        public static void UpdateNewCertificatesOrAwardInTextbox()
        {
            IWebElement InputEditCertificate = driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
            InputEditCertificate.Clear();
            InputEditCertificate.SendKeys("ISTQB Foundation");

        }

        
        public static void UpdateNewCertifierSNameInTextbox()
        {
            IWebElement InputEditCertifier = driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));
            InputEditCertifier.Clear();
            InputEditCertifier.SendKeys("ISTQB Assosiation");



        }

        public static void UpdateNewYearFromDropdownList()
        {
            IWebElement AddYear = driver.FindElement(By.XPath("//select[@name='certificationYear']"));
            AddYear.Click();
            driver.FindElement(By.XPath("//select[@name='certificationYear']"));
            AddYear.SendKeys("2021");
        }

        public static void ClickOnUpdateButtonToUpdateCertificate()
        {
            IWebElement UpdateButton1 = driver.FindElement(By.XPath("//input[@value='Update']"));
            UpdateButton1.Click();

        }
        // Validate Updation
                
        public static void CertificateDetailsShouldBeUpdated()
        {
            Thread.Sleep(1500);
            String target_xpath = "//div[@class='ns-box-inner']";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));
                       
            String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("has been updated to your certification"));

        }

       // Delete Certificate
        public static void ClickOnDeleteButtonNextToCertificateDetailsIWantToDelete()
        {
            IWebElement DeleteButton1 = driver.FindElement(By.XPath("//tbody[1]/tr[1]/td[4]/span[2]/i[1]"));
            DeleteButton1.Click();

        }

       // Validate Deletion
        public static void CertificateDetailsShouldBeDeleted()
        {
            Thread.Sleep(1500);
            String target_xpath = "//div[@class='ns-box-inner']";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

           String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("has been deleted from your certification"));

        }
    }
}
