using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryCSS
{
    static void Main()
    {
        string url = "https://testing.todorvachev.com/css-path/";
        string cssPath = "#post-108 > div > figure > img";
        string xPath = "//*[@id=\"post-108\"]/div/figure/img";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath));
        IWebElement xPathElement = driver.FindElement(By.XPath(xPath));


        if (cssPathElement.Displayed)
        {
            GreenMessage("I can see the CSS Path Element!");
        }
        else
        {
            RedMessage("I can't see the CSS Path Element!");
        }

        if (xPathElement.Displayed)
        {
            GreenMessage("I can see the X Path Element!");
        }
        else
        {
            RedMessage("I can't see the X Path Element!");
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
