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
    public class Language 
    {               
        private static IWebElement AddButton => Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
        private static IWebElement AddLanguage => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        private static IWebElement AddLevel => Driver.driver.FindElement(By.XPath("//select[@name='level']"));
        private static IWebElement AddLanguageButton => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
        private static IWebElement EditLanguageButton =>Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
        private static IWebElement UpdateLanguageButton => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
       private static IWebElement DeleteLanguageButton =>Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));


        //Click on Languages Add New button

        public static void ClickOnAddNewButtonInLanguagesTab()
        {
             AddButton.Click();

        }

        //Funtion to input a language to the language text box
        public static void AddInTextbox(string language)
        {           
            AddLanguage.SendKeys(language);
        }


        //Function to choose from Language level drop down

        public static void ChooseALevelForLanguageFromDropdownList(string Level)
        {
            AddLevel.Click();
            AddLevel.SendKeys(Level);

        }

        //Function to click on the Add button under Languages tab

        public static void ClickOnAddButton()
        {
            
            AddLanguageButton.Click();
        }

        public static void LanguageShouldBeAddedToMyProfile()
        {
            Wait.WaitForWebElement(Driver.driver, "//div[@class='ns-box-inner']","XPath", 20);
            
            String target_xpath = "//div[@class='ns-box-inner']";

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(15));
            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

            String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("has been added to your languages"));
        }

        // Edit Language
        // Click on Edit button
        public static void ClickOnEditButtonNextToLanguageIWantToEdit()
        {
            
            EditLanguageButton.Click();
        }

        // Input new values
        public static void ReplaceOldInputInTextboxWithNewLanguage()
        {
                       
            AddLanguage.Clear();
            AddLanguage.SendKeys("Italian");
        }

        public static void GivenIReplaceOldInputInDropdownListWithNewLevel()

        {
            AddLevel.Click();
            AddLevel.SendKeys("Basic");
        }

        // Click on Update Button
        public static void ClickOnUpdateButton()
        {
           
            UpdateLanguageButton.Click();
        }
        // Validate Updated language
        public static void LanguageShouldBeUpdated()
        {
            Wait.WaitForWebElement(Driver.driver, "//div[@class='ns-box-inner']", "XPath", 20);

            String target_xpath = "//div[@class='ns-box-inner']";
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(15));

            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

            String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("has been updated to your languages"));
        }

        // Delete Language

        public static void ClickOnCrossSignNextToTheLanguageIWantToDelete()
        {
            
            DeleteLanguageButton.Click();
        }

        // Validate Deletion
        public static void LanguageShouldBeDeleted()
        {
            Wait.WaitForWebElement(Driver.driver, "//div[@class='ns-box-inner']", "XPath", 20);

            String target_xpath = "//div[@class='ns-box-inner']";
            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(15));

            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

            String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("has been deleted from your languages"));
        }
    }
}