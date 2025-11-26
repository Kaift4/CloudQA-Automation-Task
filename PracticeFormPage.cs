using OpenQA.Selenium;

namespace CloudQA.Pages
{
    public class PracticeFormPage
    {
        private readonly IWebDriver driver;

        public PracticeFormPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement FirstNameInput =>
            driver.FindElement(By.XPath("//label[contains(text(),'First Name')]/following::input[1]"));

        private IWebElement GenderMaleRadio =>
            driver.FindElement(By.XPath("//label[contains(text(),'Male')]"));

        private IWebElement SubmitButton =>
            driver.FindElement(By.XPath("//button[contains(., 'Submit')]"));

        public void EnterFirstName(string name)
        {
            FirstNameInput.Clear();
            FirstNameInput.SendKeys(name);
        }

        public void SelectMaleGender()
        {
            GenderMaleRadio.Click();
        }

        public void Submit()
        {
            SubmitButton.Click();
        }
    }
}
