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
    
        public class Education : Driver
        {
            // Add Education
            public static void ClickOnEducationTab()
            {
                IWebElement EducationTab = driver.FindElement(By.XPath("//a[normalize-space()='Education']"));
                EducationTab.Click();

            }
                        
            public static void ClickOnAddNewButtonToAddEducation()
            {
                IWebElement CertificationsAddButton = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
                CertificationsAddButton.Click();
            }

            public static void PassInTextbox(string College)
            {
                IWebElement AddCollege = driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
                AddCollege.SendKeys(College);

            }
                        
            public static void PassFromDropdownWhereIDidMyEducation(string Country)
            {
                IWebElement AddCountry = driver.FindElement(By.XPath("//select[@name='country']"));
                AddCountry.Click();
                driver.FindElement(By.XPath("//select[@name='country']"));
                AddCountry.SendKeys(Country);

            }
                       
            public static void PassFromDropdownList(string Title)
            {
                IWebElement AddTitle = driver.FindElement(By.XPath("//select[@name='title']"));
                AddTitle.Click();
                driver.FindElement(By.XPath("//select[@name='title']"));
                AddTitle.SendKeys(Title);
            }

            public static void PassInField(string Degree)
            {
                IWebElement AddDegree = driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
                AddDegree.SendKeys(Degree);
            }
                        
            public static void PassFromDropdown(string GraduatedYear)
            {
                IWebElement AddGraduatedYear = driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
                AddGraduatedYear.Click();
                driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
                AddGraduatedYear.SendKeys(GraduatedYear);
            }

            public static void ClickOnAddButton()
            {
                IWebElement AddButton1 = driver.FindElement(By.XPath("//input[@value='Add']"));
                AddButton1.Click();

            }

            // Validate Education in profile
            public static void EducationDetailsShouldBeAdded()
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

           // Edit Education
            public static void ClickOnEditButtonNextToEducationalDetailsIWantToEdit()
            {
                IWebElement EditButton1 = driver.FindElement(By.XPath("//tbody/tr/td[6]/span[1]/i[1]"));
                EditButton1.Click();

            }

            public static void ProvideNewCollegeUniversityNameInTextbox()
            {
                IWebElement AddCollege = driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
                AddCollege.Clear();
                AddCollege.SendKeys("St James");


            }

            public static void ProvideNewCountryFromDropdownWhereIDidMyEducation()
            {
                IWebElement AddCountry = driver.FindElement(By.XPath("//select[@name='country']"));
                AddCountry.Click();
                driver.FindElement(By.XPath("//select[@name='country']"));
                AddCountry.SendKeys("Australia");
            }

            public static void ProvideNewTitleFromDropdownList()
            {
                IWebElement AddTitle = driver.FindElement(By.XPath("//select[@name='title']"));
                AddTitle.Click();
                driver.FindElement(By.XPath("//select[@name='title']"));
                AddTitle.SendKeys("B.Tech");
            }

            
            public static void ProvideNewDegreeInTextbox()
            {
                IWebElement AddDegree = driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
                AddDegree.SendKeys("Electronics");
            }

            public static void ProvideNewYearOfGraduationFromDropdownList()
            {
                IWebElement AddGraduatedYear = driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
                AddGraduatedYear.Click();
                driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
                AddGraduatedYear.SendKeys("2001");
            }

            
            public static void ClickOnUpdateButton()
            {
                IWebElement UpdateButton1 = driver.FindElement(By.XPath("//input[@value='Update']"));
                UpdateButton1.Click();

            }

            // Validate updated education
            public static void EducationDetailsShouldBeUpdated()
            {
                Thread.Sleep(1500);
                String target_xpath = "//div[@class='ns-box-inner']";
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

                String message1 = message.Text;

                Console.WriteLine(message1);
                Assert.True(message1.Contains("as been updated"));

            }

            // Delete education 
            public static void ClickOnCrossSignNextToTheEducationalDetailsIWantToDelete()
            {
                IWebElement DeleteButton1 = driver.FindElement(By.XPath("//tbody/tr/td[6]/span[2]/i[1]"));
                DeleteButton1.Click();

            }

           // Validate Deletion
            public static void EducationalDetailsShouldBeDeleted()
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
