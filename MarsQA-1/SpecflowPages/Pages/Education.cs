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
    
        public class Education
        {

            private static IWebElement EducationTab =>Driver.driver.FindElement(By.XPath("//a[normalize-space()='Education']"));
            private static IWebElement CertificationsAddButton =>Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
            private static IWebElement AddCollege =>Driver.driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
            private static IWebElement AddCountry =>Driver.driver.FindElement(By.XPath("//select[@name='country']"));
            private static IWebElement AddTitle =>Driver.driver.FindElement(By.XPath("//select[@name='title']"));
            private static IWebElement AddDegree =>Driver.driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
            private static IWebElement AddGraduatedYear =>Driver.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
            private static IWebElement AddButton1 =>Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
            private static IWebElement EditButton1 =>Driver.driver.FindElement(By.XPath("//tbody/tr/td[6]/span[1]/i[1]"));
            private static IWebElement UpdateButton1 =>Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
            private static IWebElement DeleteButton1 =>Driver.driver.FindElement(By.XPath("//tbody/tr/td[6]/span[2]/i[1]"));

        // Add Education
        public static void ClickOnEducationTab()
            {
                
                EducationTab.Click();

            }
                        
            public static void ClickOnAddNewButtonToAddEducation()
            {
                
                CertificationsAddButton.Click();
            }

            public static void PassInTextbox(string College)
            {
               
                AddCollege.SendKeys(College);

            }
                        
            public static void PassFromDropdownWhereIDidMyEducation(string Country)
            {
                
                AddCountry.Click();
                AddCountry.SendKeys(Country);

            }
                       
            public static void PassFromDropdownList(string Title)
            {
               
                AddTitle.Click();
                AddTitle.SendKeys(Title);
            }

            public static void PassInField(string Degree)
            {
               
                AddDegree.SendKeys(Degree);
            }
                        
            public static void PassFromDropdown(string GraduatedYear)
            {
                
                AddGraduatedYear.Click();
                AddGraduatedYear.SendKeys(GraduatedYear);
            }

            public static void ClickOnAddButton()
            {
                
                AddButton1.Click();

            }

            // Validate Education in profile
            public static void EducationDetailsShouldBeAdded()
            {

            Wait.WaitForWebElement(Driver.driver, "//div[@class='ns-box-inner']", "XPath", 20);

            String target_xpath = "//div[@class='ns-box-inner']";
                WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20));

                IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

                //IWebElement message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
                String message1 = message.Text;

                Console.WriteLine(message1);
                Assert.True(message1.Contains("has been added"));

            }

           // Edit Education
            public static void ClickOnEditButtonNextToEducationalDetailsIWantToEdit()
            {
                
                EditButton1.Click();

            }

            public static void ProvideNewCollegeUniversityNameInTextbox()
            {
                
                AddCollege.Clear();
                AddCollege.SendKeys("St James");


            }

            public static void ProvideNewCountryFromDropdownWhereIDidMyEducation()
            {
               
                AddCountry.Click();
                AddCountry.SendKeys("Australia");
            }

            public static void ProvideNewTitleFromDropdownList()
            {
               
                AddTitle.Click();
                AddTitle.SendKeys("B.Tech");
            }

            
            public static void ProvideNewDegreeInTextbox()
            {
                
                AddDegree.SendKeys("Electronics");
            }

            public static void ProvideNewYearOfGraduationFromDropdownList()
            {
                
                AddGraduatedYear.Click();
                AddGraduatedYear.SendKeys("2001");
            }

            
            public static void ClickOnUpdateButton()
            {
                
                UpdateButton1.Click();

            }

            // Validate updated education
            public static void EducationDetailsShouldBeUpdated()
            {

            Wait.WaitForWebElement(Driver.driver, "//div[@class='ns-box-inner']", "XPath", 20);

            String target_xpath = "//div[@class='ns-box-inner']";
                WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20));

                IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

                String message1 = message.Text;

                Console.WriteLine(message1);
                Assert.True(message1.Contains("as been updated"));

            }

            // Delete education 
            public static void ClickOnCrossSignNextToTheEducationalDetailsIWantToDelete()
            {
                
                DeleteButton1.Click();

            }

           // Validate Deletion
            public static void EducationalDetailsShouldBeDeleted()
            {

            Wait.WaitForWebElement(Driver.driver, "//div[@class='ns-box-inner']", "XPath", 20);

            String target_xpath = "//div[@class='ns-box-inner']";
                WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(20));

                IWebElement message = wait.Until(ExpectedConditions.ElementExists(By.XPath(target_xpath)));

                //IWebElement message = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
                String message1 = message.Text;

                Console.WriteLine(message1);
                Assert.True(message1.Contains("successfully removed"));

            }
        }
}
