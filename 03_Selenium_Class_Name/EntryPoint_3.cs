using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryClassName
{
    static void Main()
    {
        string url = "https://testing.todorvachev.com/class-name/";
        string className = "testClass";


        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement Element = driver.FindElement(By.ClassName(className));

        Console.WriteLine(Element.Text);

        driver.Quit();

    }

}
