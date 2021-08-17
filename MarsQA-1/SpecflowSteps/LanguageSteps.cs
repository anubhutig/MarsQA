using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.Support.UI;
using MarsQA_1.SpecflowPages.Pages;

namespace MarsQA_1.SpecflowSteps.Pages
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
           Language.ClickOnAddNewButtonInLanguagesTab();
        }

        [Given(@"I add (.*) in textbox")]
        public void GivenIAddInTextbox(string language)
        {
            Language.AddInTextbox(language);
            
        }


        [Given(@"I choose a (.*) for language from dropdown list")]
        public void GivenIChooseALevelForLanguageFromDropdownList(string Level)
        {
            Language.ChooseALevelForLanguageFromDropdownList(Level);

        }

        [When(@"I click on Add Button")]
        public void WhenIClickOnAddButton()
        {
            Language.ClickOnAddButton();
        }
        
        [Then(@"The language should be added to my profile")]
        public void ThenTheLanguageShouldBeAddedToMyProfile()
        {
            Language.LanguageShouldBeAddedToMyProfile();
        }
       
        [Given(@"I click on Edit Button next to language I want to edit")]
        public void GivenIClickOnEditButtonNextToLanguageIWantToEdit()
        {
            Language.ClickOnEditButtonNextToLanguageIWantToEdit();
        }

        [Given(@"I replace old input in textbox with new language")]
        public void GivenIReplaceOldInputInTextboxWithNewLanguage()
        {

            Language.ReplaceOldInputInTextboxWithNewLanguage();
            
        }

        [Given(@"I replace old input in dropdown list with new level")]
        public void GivenIReplaceOldInputInDropdownListWithNewLevel()

        {
            Language.GivenIReplaceOldInputInDropdownListWithNewLevel();
        }

        [When(@"I click on Update Button")]
        public void WhenIClickOnUpdateButton()
        {
            Language.ClickOnUpdateButton();                                         
        }

        [Then(@"the language should be updated")]
        public void ThenTheLanguageShouldBeUpdated()
        {
            Language.LanguageShouldBeUpdated();
        }

       
       [When(@"I click on cross sign next to the language I want to delete")]
        public void WhenIClickOnCrossSignNextToTheLanguageIWantToDelete()
        {
            Language.ClickOnCrossSignNextToTheLanguageIWantToDelete(); 
        }

       [Then(@"the language should be deleted")]
        public void ThenTheLanguageShouldBeDeleted()
        {
            Language.LanguageShouldBeDeleted();
        }


    }
}
