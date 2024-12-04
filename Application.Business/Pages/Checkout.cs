namespace Application.Business.Pages;

using Application.Model.Pages;
using Common.Utils.NumberGenerators;

public class Checkout : BusinessBase
{
    public Checkout() : base(new CheckoutPage()) { }
    public Checkout(CheckoutPage checkoutPage) : base(checkoutPage) { }

    public void InputCreditCard()
    {
        CheckoutPage.CardNumber.Text = NumberGenerators.GenerateCardNumber("4");
        CheckoutPage.ExpiryDate.Text = NumberGenerators.GenerateExpiryDate();
        CheckoutPage.SecurityCode.Text = NumberGenerators.GenerateSecurityCode();
    }

    public bool IsCheckoutVisible()
    {
        return CheckoutPage.MainContent.IsVisible;
    }

    public bool IsErrorMessageVisible()
    {
        return CheckoutPage.ErrorMessage.IsVisible;
    }
}