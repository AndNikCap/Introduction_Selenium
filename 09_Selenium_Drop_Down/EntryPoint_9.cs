using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryDropDown
{
    static IWebDriver driver = new ChromeDriver();

    static void Main()
    {
        string url = "https://testing.todorvachev.com/drop-down-menu-test/";

        string dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";

        IWebElement dropDownMenu;

        IWebElement elementFromTheDropDownMenu;

        driver.Navigate().GoToUrl(url);

        dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

        Console.WriteLine("The selected value is: " + dropDownMenu.GetAttribute("value"));

        elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

        Console.WriteLine("The third option from dropdon menu is: " + elementFromTheDropDownMenu.GetAttribute("value"));

        elementFromTheDropDownMenu.Click();

        Console.WriteLine("The selected value is: " + dropDownMenu.GetAttribute("value"));

        Thread.Sleep(5000);


        driver.Quit();

    }


}
