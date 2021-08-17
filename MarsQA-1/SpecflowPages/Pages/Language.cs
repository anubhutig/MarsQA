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
    public class Language : Driver
    {

        //Click on Languages Add New button

        public static void ClickOnAddNewButtonInLanguagesTab()
        {
            IWebElement AddButton = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
            AddButton.Click();

        }

        //Funtion to input a language to the language text box
        public static void AddInTextbox(string language)
        {

            IWebElement AddLanguage = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            AddLanguage.SendKeys(language);
        }


        //Function to choose from Language level drop down

        public static void ChooseALevelForLanguageFromDropdownList(string Level)
        {
            IWebElement AddLevel = driver.FindElement(By.XPath("//select[@name='level']"));
            AddLevel.Click();
            driver.FindElement(By.XPath("//select[@name='level']")).SendKeys(Level);


        }

        //Function to click on the Add button under Languages tab

        public static void ClickOnAddButton()
        {
            IWebElement AddLanguageButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            AddLanguageButton.Click();
        }

        public static void LanguageShouldBeAddedToMyProfile()
        {
            Thread.Sleep(1500);
            String target_xpath = "//div[@class='ns-box-inner']";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

            String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("has been added to your languages"));
        }

        // Edit Language
        // Click on Edit button
        public static void ClickOnEditButtonNextToLanguageIWantToEdit()
        {

            IWebElement EditLanguageButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
            EditLanguageButton.Click();
        }

        // Input new values
        public static void ReplaceOldInputInTextboxWithNewLanguage()
        {

            IWebElement EditLanguage = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            EditLanguage.Clear();
            EditLanguage.SendKeys("Italian");
        }

        public static void GivenIReplaceOldInputInDropdownListWithNewLevel()

        {
            IWebElement AddLevel = driver.FindElement(By.XPath("//select[@name='level']"));
            AddLevel.Click();
            driver.FindElement(By.XPath("//select[@name='level']")).SendKeys("Basic");
        }

        // Click on Update Button
        public static void ClickOnUpdateButton()
        {
            IWebElement UpdateLanguageButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            UpdateLanguageButton.Click();
        }
        // Validate Updated language
        public static void LanguageShouldBeUpdated()
        {
            Thread.Sleep(1500);
            String target_xpath = "//div[@class='ns-box-inner']";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

            String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("has been updated to your languages"));
        }

        // Delete Language

        public static void ClickOnCrossSignNextToTheLanguageIWantToDelete()
        {
            IWebElement DeleteLanguageButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
            DeleteLanguageButton.Click();
        }

        // Validate Deletion
        public static void LanguageShouldBeDeleted()
        {
            Thread.Sleep(1500);
            String target_xpath = "//div[@class='ns-box-inner']";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

            String message1 = message.Text;

            Console.WriteLine(message1);
            Assert.True(message1.Contains("has been deleted from your languages"));
        }
    }
}