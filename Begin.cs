using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace nunit_test;

public class Begin
{
    public IWebDriver _driver;

    [SetUp]
    public void InicioTeste()
    {
        _driver = new ChromeDriver();
        _driver.Navigate().GoToUrl("http://www.buscacep.correios.com.br");
        _driver.Manage().Window.Maximize();
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
    }

    [TearDown]
    public void Resultado()
    {
        _driver.Quit();
    }
}