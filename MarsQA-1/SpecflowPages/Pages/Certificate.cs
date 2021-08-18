using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Utils;
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
    class Certificate 
    {
        
        private static IWebElement CertificationsButton =>Driver.driver.FindElement(By.XPath("//a[normalize-space()='Certifications']"));
        private static IWebElement AddNewButton =>Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
        private static IWebElement AddCertificate =>Driver.driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
        private static IWebElement AddCertifier =>Driver.driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));
        private static IWebElement AddYear =>Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']"));
        private static IWebElement AddButton1 =>Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
        private static IWebElement EditButton1 =>Driver.driver.FindElement(By.XPath("//tbody/tr/td[4]/span[1]/i[1]"));
        private static IWebElement UpdateButton1 =>Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement DeleteButton1 =>Driver.driver.FindElement(By.XPath("//tbody[1]/tr[1]/td[4]/span[2]/i[1]"));
       
        // Adding Certificate 
        public static void ClickOnCertificatesTab()
        {
            
            CertificationsButton.Click();

        }
                
        public static void ClickOnAddNewButton()
        {
           
            AddNewButton.Click();

        }

        public static void InputInTextbox(string Award)
        {
            
            AddCertificate.SendKeys(Award);

        }

        public static void TypeInBox(string Certifier)
        {
            
            AddCertifier.SendKeys(Certifier);

        }

        public static void SelectFromDropdownList(string Year)
        {
            
            AddYear.Click();
            AddYear.SendKeys(Year);

        }

        public static void ClickOnAddButtonToAddCertificate()
        {
            
            AddButton1.Click();

        }

        public static void CertificateDetailsShouldBeAdded()
        {
            Wait.WaitForWebElement(Driver.driver, "//div[@class='ns-box-inner']", "XPath", 20);

            String target_xpath = "//div[@class='ns-box-inner']";
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20));

            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));
                        
            String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("has been added to your certification"));

        }

        // Edit Certificate Details
        public static void ClickOnEditButtonNextToCertificateDetailsIWantToEdit()
        {
            
            EditButton1.Click();

        }

        public static void UpdateNewCertificatesOrAwardInTextbox()
        {
            
            AddCertificate.Clear();
            AddCertificate.SendKeys("ISTQB Foundation");

        }

        
        public static void UpdateNewCertifierSNameInTextbox()
        {
            
            AddCertifier.Clear();
            AddCertifier.SendKeys("ISTQB Assosiation");



        }

        public static void UpdateNewYearFromDropdownList()
        {
            
            AddYear.Click();
            AddYear.SendKeys("2021");
        }

        public static void ClickOnUpdateButtonToUpdateCertificate()
        {
           
            UpdateButton1.Click();

        }
        // Validate Updation
                
        public static void CertificateDetailsShouldBeUpdated()
        {
            Wait.WaitForWebElement(Driver.driver, "//div[@class='ns-box-inner']", "XPath", 20);

            String target_xpath = "//div[@class='ns-box-inner']";
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20));

            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));
                       
            String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("has been updated to your certification"));

        }

       // Delete Certificate
        public static void ClickOnDeleteButtonNextToCertificateDetailsIWantToDelete()
        {
            
            DeleteButton1.Click();

        }

       // Validate Deletion
        public static void CertificateDetailsShouldBeDeleted()
        {
            Wait.WaitForWebElement(Driver.driver, "//div[@class='ns-box-inner']", "XPath", 20);

            String target_xpath = "//div[@class='ns-box-inner']";
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20));

            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

           String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("has been deleted from your certification"));

        }
    }
}
