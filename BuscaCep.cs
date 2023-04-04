using OpenQA.Selenium;

namespace nunit_test;

public class BuscaCep : Begin
{

    [Test]
    public void Teste()
    {
        _driver.FindElement(By.Id("endereco")).SendKeys("Rua Edgar Lima, Bangu - Rio de Janeiro");
        _driver.FindElement(By.Id("btn_pesquisar")).Click();
        Assert.That(_driver.FindElement(By.XPath("//*[@id='resultado-DNEC']/tbody/tr/td[4]")).Text.Contains("21815-340"), Is.True);
    }

}