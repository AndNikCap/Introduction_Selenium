using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryCheckBox
{
    static IWebDriver driver = new ChromeDriver();

    static void Main()
    {
        string url = "https://testing.todorvachev.com/check-button-test-3/";
        IWebElement checkBox;
        string valueCheckBox = "1";

        driver.Navigate().GoToUrl(url);

        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(" + valueCheckBox + ")"));


        Console.WriteLine(checkBox.GetAttribute("value"));

        valueCheckBox = "3";

        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(" + valueCheckBox + ")"));


        Console.WriteLine(checkBox.GetAttribute("value"));


        driver.Quit();

    }

}
