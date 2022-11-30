using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryRadioBox
{
    static IWebDriver driver = new ChromeDriver();

    static void Main()
    {
        string url = "https://testing.todorvachev.com/radio-button-test/";
        IWebElement radioButton;

        driver.Navigate().GoToUrl(url);

        {
            radioButton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(1)"));

            if
                (radioButton.GetAttribute("checked") == "true")
            {
                Console.WriteLine("This radio button is checked!");
            }
            else
            {
                Console.WriteLine("This is one of the unchecked radio buttons!");
            }

        }

        driver.Quit();

    }


}
