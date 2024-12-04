namespace Application.Model.Pages;

using Application.Model.PageElements;
using Application.Model.PageElements.Login;
using Application.Model.PageElements.Library;

using Common.Configuration;
using Application.Model.PageElements.Player;
using OpenQA.Selenium;
using Common.DriverWrapper.Impl.Selenium;

public class CheckoutPage : ModelBase
{
    private const string mainContentCSS = "div[data-sentry-element='PageContent']";
    private const string cardNumberCSS = "input[id='cardnumber']";
    private const string expiryDateCSS = "input[id='expiry-date']";
    private const string securityCodeCSS = "input[id='security-code']";//id="cardnumber-error"
    private const string errorMsgCSS = "p[id='cardnumber-error']";
    public CheckoutPage()
    {
        
    }
    public static ModelControlBase MainContent => new(Driver.FindElementByCss(mainContentCSS));
    public static InputControl CardNumber => new(Driver.FindElementByCss(cardNumberCSS));
    public static InputControl ExpiryDate => new(Driver.FindElementByCss(expiryDateCSS));
    public static InputControl SecurityCode => new(Driver.FindElementByCss(securityCodeCSS));
    public static ModelControlBase ErrorMessage => new(Driver.FindElementByCss(errorMsgCSS));
}
