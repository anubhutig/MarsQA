using MarsQA_1.Helpers;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace MarsQA_1.SpecflowSteps
{
    [Binding]
    public class CertificatesSteps : Driver
    {
        [Given(@"I am on Profile page")]
        public void GivenIAmOnProfilePage()
        {
            
        }
        
        [Given(@"I click on Certificates Tab")]
        public void GivenIClickOnCertificatesTab()
        {
            IWebElement CertificationsButton = driver.FindElement(By.XPath("//a[normalize-space()='Certifications']"));
            CertificationsButton.Click();

        }

        [Given(@"I click on Add New Button")]
        public void GivenIClickOnAddNewButton()
        {
            IWebElement AddNewButton = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
            AddNewButton.Click();

        }

        [Given(@"I input (.*) in textbox")]
        public void GivenIInputInTextbox(string Award)
        {
            IWebElement AddCertificate = driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
            AddCertificate.SendKeys(Award);

        }

        [Given(@"I type (.*) in box")]
        public void GivenITypeInBox(string Certifier)
        {
            IWebElement AddCertifier = driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));
            AddCertifier.SendKeys(Certifier);

        }

        [Given(@"I select (.*) from dropdown list")]
        public void GivenISelectFromDropdownList(string Year)
        {
            IWebElement AddYear = driver.FindElement(By.XPath("//select[@name='certificationYear']"));
            AddYear.Click();
            driver.FindElement(By.XPath("//select[@name='certificationYear']"));
            AddYear.SendKeys(Year);

        }

        [When(@"I click on Add button to add certificate")]
        public void WhenIClickOnAddButtonToAddCertificate()
        {
            IWebElement AddButton1 = driver.FindElement(By.XPath("//input[@value='Add']"));
            AddButton1.Click();

        }

        [Then(@"My certificate details should be added")]
        public void ThenMyCertificateDetailsShouldBeAdded()
        {
            Thread.Sleep(1500);
            String target_xpath = "//div[@class='ns-box-inner']"; 
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

            //IWebElement message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("has been added to your certification"));

        }

        [Given(@"I click on Edit Button next to Certificate details I want to edit")]
        public void GivenIClickOnEditButtonNextToCertificateDetailsIWantToEdit()
        {
            IWebElement EditButton1 = driver.FindElement(By.XPath("//tbody/tr/td[4]/span[1]/i[1]"));
            EditButton1.Click();

        }

        [Given(@"I update new Certificates or Award in textbox")]
        public void GivenIUpdateNewCertificatesOrAwardInTextbox()
        {
            IWebElement InputEditCertificate = driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
            InputEditCertificate.Clear();
            InputEditCertificate.SendKeys("ISTQB Foundation");

        }

        [Given(@"I update new Certifier's Name in textbox")]
        public void GivenIUpdateNewCertifierSNameInTextbox()
        {
            IWebElement InputEditCertifier = driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));
            InputEditCertifier.Clear();
            InputEditCertifier.SendKeys("ISTQB");



        }

        [Given(@"I update new Year from dropdown list")]
        public void GivenIUpdateNewYearFromDropdownList()
        {
           
        }

        [When(@"I click on Update button to update certificate")]
        public void WhenIClickOnUpdateButtonToUpdateCertificate()
        {
            IWebElement UpdateButton1 = driver.FindElement(By.XPath("//input[@value='Update']"));
            UpdateButton1.Click();

        }

        [Then(@"My certificate details should be updated")]
        public void ThenMyCertificateDetailsShouldBeUpdated()
        {
            Thread.Sleep(1500);
            String target_xpath = "//div[@class='ns-box-inner']";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

            //IWebElement message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("has been updated to your certification"));

        }

        [When(@"I click on Delete Button next to Certificate details I want to delete")]
        public void WhenIClickOnDeleteButtonNextToCertificateDetailsIWantToDelete()
        {
            IWebElement DeleteButton1 = driver.FindElement(By.XPath("//tbody[1]/tr[1]/td[4]/span[2]/i[1]"));
            DeleteButton1.Click();

        }

        [Then(@"the Certificate details should be deleted")]
        public void ThenTheCertificateDetailsShouldBeDeleted()
        {
            Thread.Sleep(1500);
            String target_xpath = "//div[@class='ns-box-inner']";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

            //IWebElement message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            String message1 = message.Text;

           Console.WriteLine(message1);
            Assert.True(message1.Contains("has been deleted from your certification"));

        }


    }
}
