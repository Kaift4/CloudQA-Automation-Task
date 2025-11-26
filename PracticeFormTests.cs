using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using CloudQA.Pages;

namespace CloudQA.Tests
{
    public class PracticeFormTests
    {
        private IWebDriver driver;
        private PracticeFormPage page;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

            page = new PracticeFormPage(driver);
        }

        [Test]
        public void TestFirstNameField()
        {
            page.EnterFirstName("Kaif");
            Assert.Pass("First Name field accepted text successfully.");
        }

        [Test]
        public void TestGenderField()
        {
            page.SelectMaleGender();
            Assert.Pass("Gender radio button clicked successfully.");
        }

        [Test]
        public void TestSubmitButton()
        {
            page.Submit();
            Assert.Pass("Submit button clicked successfully.");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
