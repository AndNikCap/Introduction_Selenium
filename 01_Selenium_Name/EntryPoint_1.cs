using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryName
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("https://testing.todorvachev.com/name/");

        IWebElement element = driver.FindElement(By.Name("myName"));

        if (element.Displayed)
        {
            GreenMessage("Yes! I Can see the element, it's right there !!!");
        }
        else
        {
            RedMessage("Well, something went wrong, I couldn't see the element");
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
