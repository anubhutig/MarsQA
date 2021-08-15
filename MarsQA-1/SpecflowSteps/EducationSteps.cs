using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace MarsQA_1.SpecflowSteps
{
    [Binding]
    public class EducationSteps : Driver
    {
        [Given(@"I click on Education Tab")]
        public void GivenIClickOnEducationTab()
        {
            IWebElement EducationTab = driver.FindElement(By.XPath("//a[normalize-space()='Education']"));
            EducationTab.Click();


        }

        [Given(@"I click on Add New Button to add education")]
        public void GivenIClickOnAddNewButtonToAddEducation()
        {
            IWebElement CertificationsAddButton = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
            CertificationsAddButton.Click();                                    
        }
        
        [Given(@"I  pass (.*) in textbox")]
        public void GivenIPassInTextbox(string College)
        {
            IWebElement AddCollege = driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
            AddCollege.SendKeys(College);

        }

        [Given(@"I pass (.*) from dropdown where I did my Education")]
        public void GivenIPassFromDropdownWhereIDidMyEducation(string Country)
        {
            IWebElement AddCountry = driver.FindElement(By.XPath("//select[@name='country']"));
            AddCountry.Click();            
            driver.FindElement(By.XPath("//select[@name='country']"));
            AddCountry.SendKeys(Country);

        }

        [Given(@"I pass (.*)from dropdown list")]
        public void GivenIPassFromDropdownList(string Title)
        {
            IWebElement AddTitle = driver.FindElement(By.XPath("//select[@name='title']"));
            AddTitle.Click();
            driver.FindElement(By.XPath("//select[@name='title']"));
            AddTitle.SendKeys(Title);
        }

        [Given(@"I pass (.*) in field")]
        public void GivenIPassInField(string Degree)
        {
            IWebElement AddDegree = driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
            AddDegree.SendKeys(Degree);
        }


      
        [Given(@"I pass (.*) from dropdown")]
        public void GivenIPassFromDropdown(string GraduatedYear)
        {
            IWebElement AddGraduatedYear = driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
            AddGraduatedYear.Click();
            driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
            AddGraduatedYear.SendKeys(GraduatedYear);
        }
        
        [When(@"I click on Add button")]
        public void WhenIClickOnAddButton()
        {
            IWebElement AddButton1 = driver.FindElement(By.XPath("//input[@value='Add']"));
            AddButton1.Click();

        }

        [Then(@"My education details should be added")]
        public void ThenMyEducationDetailsShouldBeAdded()
        {
            Thread.Sleep(1500);
            String target_xpath = "//div[@class='ns-box-inner']";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

            //IWebElement message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("has been added"));

        }

        [Given(@"I click on Edit Button next to Educational details I want to edit")]
        public void GivenIClickOnEditButtonNextToEducationalDetailsIWantToEdit()
        {
            IWebElement EditButton1 = driver.FindElement(By.XPath("//tbody/tr/td[6]/span[1]/i[1]"));
            EditButton1.Click();

        }

        [Given(@"I provide new College/University Name in textbox")]
        public void GivenIProvideNewCollegeUniversityNameInTextbox()
        {
            IWebElement AddCollege = driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
            AddCollege.Clear();
            AddCollege.SendKeys("St James");            


        }

        [Given(@"I provide new country from dropdown where I did my Education")]
        public void GivenIProvideNewCountryFromDropdownWhereIDidMyEducation()
        {
           
        }

        [Given(@"I provide new Title from dropdown list")]
        public void GivenIProvideNewTitleFromDropdownList()
        {
           
        }

        [Given(@"I provide new Degree in textbox")]
        public void GivenIProvideNewDegreeInTextbox()
        {
            
        }

        [Given(@"I provide new year of graduation from dropdown list")]
        public void GivenIProvideNewYearOfGraduationFromDropdownList()
        {
            
        }

        [When(@"I click on Update button")]
        public void WhenIClickOnUpdateButton()
        {
            IWebElement UpdateButton1 = driver.FindElement(By.XPath("//input[@value='Update']"));
            UpdateButton1.Click();

        }

        [Then(@"My education details should be updated")]
        public void ThenMyEducationDetailsShouldBeUpdated()
        {
            Thread.Sleep(1500);
            String target_xpath = "//div[@class='ns-box-inner']";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

            //IWebElement message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("as been updated"));

        }

        [When(@"I click on cross sign next to the educational details I want to delete")]
        public void WhenIClickOnCrossSignNextToTheEducationalDetailsIWantToDelete()
        {
            IWebElement DeleteButton1 = driver.FindElement(By.XPath("//tbody/tr/td[6]/span[2]/i[1]"));
            DeleteButton1.Click();

        }

        [Then(@"the educational details should be deleted")]
        public void ThenTheEducationalDetailsShouldBeDeleted()
        {
            Thread.Sleep(1500);
            String target_xpath = "//div[@class='ns-box-inner']";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

            //IWebElement message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("successfully removed"));

        }


    }
}
