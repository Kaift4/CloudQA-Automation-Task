# CloudQA Automation Task – Selenium C#

This repository contains automated UI tests for the CloudQA Automation Practice Form, implemented using C#, Selenium WebDriver, and the Page Object Model (POM) pattern.

The tests are designed to remain stable even if the page structure or HTML attributes change, as requested in the assignment brief.

---

## Project Overview

CloudQA requested an automation task involving:

- Writing automated tests for any three fields on the form.
- Ensuring the tests continue to work even if element attributes or positions change.

This project fulfills the requirements by using relationship-based and text-based element locators instead of relying on IDs, classes, or fragile DOM positions.

---

## Technologies Used

- C# (.NET)
- Selenium WebDriver
- NUnit
- ChromeDriver
- Page Object Model (POM)

---

## Test Cases Implemented

1. First Name input field  
   - Enters text and verifies interaction.

2. Gender selection (Male)  
   - Uses a text-based locator independent of DOM position.

3. Submit button  
   - Clicks and triggers form submission.

---

## Stable Locator Strategy

Rather than using element IDs or classes, which can easily change, the project uses label-based and text-based XPath selectors. For example:

```csharp
//label[contains(text(),'First Name')]/following::input[1]
```

This ensures the locator remains valid as long as the visible label text remains unchanged, making the tests resilient to layout changes or HTML refactoring.

---

## Project Structure

```
CloudQA-Automation-Task/
│
├── CloudQA.Pages/
│     └── PracticeFormPage.cs
│
├── CloudQA.Tests/
│     └── PracticeFormTests.cs
│
└── README.md
```

- CloudQA.Pages contains POM classes.
- CloudQA.Tests contains NUnit-based test classes.

---

## Running the Tests

1. Install dependencies:
   ```bash
   dotnet restore
   ```

2. Run the test suite:
   ```bash
   dotnet test
   ```

3. Ensure the appropriate version of ChromeDriver is available on your system path.

---

## Architecture Notes

- The Page Object Model helps maintain clean separation between test logic and UI interactions.
- Locators are intentionally designed for resilience rather than depending on brittle attributes.
- Code structure is aligned with common practices in UI automation frameworks.

---

## Author

Mohamad Kaif
