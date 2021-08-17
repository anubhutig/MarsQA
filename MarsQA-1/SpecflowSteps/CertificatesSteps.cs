using MarsQA_1.Helpers;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using MarsQA_1.SpecflowPages.Pages;

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
            Certificate.ClickOnCertificatesTab();

        }

        [Given(@"I click on Add New Button")]
        public void GivenIClickOnAddNewButton()
        {
            Certificate.ClickOnAddNewButton();

        }

        [Given(@"I input (.*) in textbox")]
        public void GivenIInputInTextbox(string Award)
        {
            Certificate.InputInTextbox(Award);

        }

        [Given(@"I type (.*) in box")]
        public void GivenITypeInBox(string Certifier)
        {
            Certificate.TypeInBox(Certifier);

        }

        [Given(@"I select (.*) from dropdown list")]
        public void GivenISelectFromDropdownList(string Year)
        {
            Certificate.SelectFromDropdownList(Year);

        }

        [When(@"I click on Add button to add certificate")]
        public void WhenIClickOnAddButtonToAddCertificate()
        {
            Certificate.ClickOnAddButtonToAddCertificate();

        }

        [Then(@"My certificate details should be added")]
        public void ThenMyCertificateDetailsShouldBeAdded()
        {
            Certificate.CertificateDetailsShouldBeAdded();

        }

        [Given(@"I click on Edit Button next to Certificate details I want to edit")]
        public void GivenIClickOnEditButtonNextToCertificateDetailsIWantToEdit()
        {
            Certificate.ClickOnEditButtonNextToCertificateDetailsIWantToEdit();

        }

        [Given(@"I update new Certificates or Award in textbox")]
        public void GivenIUpdateNewCertificatesOrAwardInTextbox()
        {
            Certificate.UpdateNewCertificatesOrAwardInTextbox();

        }

        [Given(@"I update new Certifier's Name in textbox")]
        public void GivenIUpdateNewCertifierSNameInTextbox()
        {
            Certificate.UpdateNewCertifierSNameInTextbox();


        }

        [Given(@"I update new Year from dropdown list")]
        public void GivenIUpdateNewYearFromDropdownList()
        {
            Certificate.UpdateNewYearFromDropdownList();
        }

        [When(@"I click on Update button to update certificate")]
        public void WhenIClickOnUpdateButtonToUpdateCertificate()
        {
            Certificate.ClickOnUpdateButtonToUpdateCertificate();

        }

        [Then(@"My certificate details should be updated")]
        public void ThenMyCertificateDetailsShouldBeUpdated()
        {
            Certificate.CertificateDetailsShouldBeUpdated();

        }

        [When(@"I click on Delete Button next to Certificate details I want to delete")]
        public void WhenIClickOnDeleteButtonNextToCertificateDetailsIWantToDelete()
        {
            Certificate.ClickOnDeleteButtonNextToCertificateDetailsIWantToDelete();

        }

        [Then(@"the Certificate details should be deleted")]
        public void ThenTheCertificateDetailsShouldBeDeleted()
        {
            Certificate.CertificateDetailsShouldBeDeleted();

        }


    }
}
