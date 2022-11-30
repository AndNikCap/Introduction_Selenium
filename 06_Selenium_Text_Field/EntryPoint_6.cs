using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryTextField
{
    static IWebDriver driver = new ChromeDriver();

    static void Main()
    {
        string url = "https://testing.todorvachev.com/text-input-field/";
        IWebElement textBox;

        driver.Navigate().GoToUrl(url);

        textBox = driver.FindElement(By.Name("username"));

        textBox.SendKeys("Test text");

        Thread.Sleep(3000);

        Console.WriteLine(textBox.GetAttribute("maxlength"));

        Thread.Sleep(3000);

        driver.Quit();

    }

}
