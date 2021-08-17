using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using MarsQA_1.SpecflowPages.Pages;

namespace MarsQA_1.SpecflowSteps
{
    [Binding]
    public class EducationSteps : Driver
    {
        [Given(@"I click on Education Tab")]
        public void GivenIClickOnEducationTab()
        {
            Education.ClickOnEducationTab();

        }

        [Given(@"I click on Add New Button to add education")]
        public void GivenIClickOnAddNewButtonToAddEducation()
        {
            Education.ClickOnAddNewButtonToAddEducation();                                
        }
        
        [Given(@"I  pass (.*) in textbox")]
        public void GivenIPassInTextbox(string College)
        {
            Education.PassInTextbox(College);

        }

        [Given(@"I pass (.*) from dropdown where I did my Education")]
        public void GivenIPassFromDropdownWhereIDidMyEducation(string Country)
        {
            Education.PassFromDropdownWhereIDidMyEducation(Country);

        }

        [Given(@"I pass (.*)from dropdown list")]
        public void GivenIPassFromDropdownList(string Title)
        {
            Education.PassFromDropdownList(Title);
        }

        [Given(@"I pass (.*) in field")]
        public void GivenIPassInField(string Degree)
        {
            Education.PassInField(Degree);
        }


      
        [Given(@"I pass (.*) from dropdown")]
        public void GivenIPassFromDropdown(string GraduatedYear)
        {
            Education.PassFromDropdown(GraduatedYear);
        }
        
        [When(@"I click on Add button")]
        public void WhenIClickOnAddButton()
        {
            Education.ClickOnAddButton();

        }

        [Then(@"My education details should be added")]
        public void ThenMyEducationDetailsShouldBeAdded()
        {
            Education.EducationDetailsShouldBeAdded();

        }

        [Given(@"I click on Edit Button next to Educational details I want to edit")]
        public void GivenIClickOnEditButtonNextToEducationalDetailsIWantToEdit()
        {
            Education.ClickOnEditButtonNextToEducationalDetailsIWantToEdit();

        }

        [Given(@"I provide new College/University Name in textbox")]
        public void GivenIProvideNewCollegeUniversityNameInTextbox()
        {
            Education.ProvideNewCollegeUniversityNameInTextbox();          


        }

        [Given(@"I provide new country from dropdown where I did my Education")]
        public void GivenIProvideNewCountryFromDropdownWhereIDidMyEducation()
        {
            Education.ProvideNewCountryFromDropdownWhereIDidMyEducation();
        }

        [Given(@"I provide new Title from dropdown list")]
        public void GivenIProvideNewTitleFromDropdownList()
        {
            Education.ProvideNewTitleFromDropdownList();
        }

        [Given(@"I provide new Degree in textbox")]
        public void GivenIProvideNewDegreeInTextbox()
        {
            Education.ProvideNewDegreeInTextbox();
        }

        [Given(@"I provide new year of graduation from dropdown list")]
        public void GivenIProvideNewYearOfGraduationFromDropdownList()
        {
            Education.ProvideNewYearOfGraduationFromDropdownList();
        }

        [When(@"I click on Update button")]
        public void WhenIClickOnUpdateButton()
        {
            Education.ClickOnUpdateButton();

        }

        [Then(@"My education details should be updated")]
        public void ThenMyEducationDetailsShouldBeUpdated()
        {
            Education.EducationDetailsShouldBeUpdated();

        }

        [When(@"I click on cross sign next to the educational details I want to delete")]
        public void WhenIClickOnCrossSignNextToTheEducationalDetailsIWantToDelete()
        {
            Education.ClickOnCrossSignNextToTheEducationalDetailsIWantToDelete();

        }

        [Then(@"the educational details should be deleted")]
        public void ThenTheEducationalDetailsShouldBeDeleted()
        {
            Education.EducationalDetailsShouldBeDeleted();
        }


    }
}
