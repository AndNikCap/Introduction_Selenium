using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryID
{
    static void Main()
    {
        string url = "https://testing.todorvachev.com/id/";
        string ID = "testImage";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement element = driver.FindElement(By.Id(ID));

        if (element.Displayed)
        {
            GreenMessage("Yes! I Can see it!");
        }
        else
        {
            RedMessage("Nope, it's not there!");
        }


        driver.Quit();

    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);

    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);

    }
}
