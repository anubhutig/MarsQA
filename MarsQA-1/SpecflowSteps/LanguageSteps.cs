using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;
using FluentAssertions;
using OpenQA.Selenium.Support.UI;



namespace MarsQA_1.SpecflowSteps
{
    [Binding]
    public class LanguageSteps : Driver
    {
        
        [Given(@"I am on Profile Page")]
        public void GivenIAmOnProfilePage()
        {
            
        }

        [Given(@"I click on Add New Button in Languages Tab")]
        public void GivenIClickOnAddNewButtonInLanguagesTab()
        {
            IWebElement AddButton = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
            AddButton.Click();

        }

        [Given(@"I add (.*) in textbox")]
        public void GivenIAddInTextbox(string Language)
        {
            
            IWebElement AddLanguage = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            AddLanguage.SendKeys(Language);
        }


        [Given(@"I choose a (.*) for language from dropdown list")]
        public void GivenIChooseALevelForLanguageFromDropdownList(string Level)
        {
            IWebElement AddLevel = driver.FindElement(By.XPath("//select[@name='level']"));
            AddLevel.Click();
            driver.FindElement(By.XPath("//select[@name='level']")).SendKeys(Level);
           

        }

        [When(@"I click on Add Button")]
        public void WhenIClickOnAddButton()
        {
            IWebElement AddLanguageButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            AddLanguageButton.Click();
        }
        
        [Then(@"The language should be added to my profile")]
        public void ThenTheLanguageShouldBeAddedToMyProfile()
        {
            Thread.Sleep(1500);
            String target_xpath = "//div[@class='ns-box-inner']";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                                    
            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));
                       
            //IWebElement message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
          String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("has been added to your languages"));
                      
            //Assert.That(driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text, Is.EqualTo("Added to your langguages"));
           // driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text.Should().Contain("added to your languages"); */
        }
       
        [Given(@"I click on Edit Button next to language I want to edit")]
        public void GivenIClickOnEditButtonNextToLanguageIWantToEdit()
        {
            
            IWebElement EditLanguageButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
            EditLanguageButton.Click();
        }

        [Given(@"I replace old input in textbox with new language")]
        public void GivenIReplaceOldInputInTextboxWithNewLanguage()
        {
            
            IWebElement EditLanguage = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            EditLanguage.Clear();
            EditLanguage.SendKeys("Italian");                                  

            
        }

        [Given(@"I replace old input in dropdown list with new level")]
        public void GivenIReplaceOldInputInDropdownListWithNewLevel()
        {
            
        }

        [When(@"I click on Update Button")]
        public void WhenIClickOnUpdateButton()
        {
            IWebElement UpdateLanguageButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            UpdateLanguageButton.Click();                                          
        }

        [Then(@"the language should be updated")]
        public void ThenTheLanguageShouldBeUpdated()
        {
            Thread.Sleep(1500);
            String target_xpath = "//div[@class='ns-box-inner']";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

            //IWebElement message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("has been updated to your languages"));
        }

       
       [When(@"I click on cross sign next to the language I want to delete")]
        public void WhenIClickOnCrossSignNextToTheLanguageIWantToDelete()
        {
            IWebElement DeleteLanguageButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
            DeleteLanguageButton.Click();
        }

       [Then(@"the language should be deleted")]
        public void ThenTheLanguageShouldBeDeleted()
        {
            Thread.Sleep(1500);
            String target_xpath = "//div[@class='ns-box-inner']";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

            //IWebElement message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("has been deleted from your languages"));
        }


    }
}
