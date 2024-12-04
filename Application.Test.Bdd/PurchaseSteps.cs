namespace Application.Bdd;

using Application.Business.PageElements.Library;
using Application.Business.PageElements.Player;
using Business.Pages;

using FluentAssertions;
using TechTalk.SpecFlow;

[Binding]
public class PurchaseSteps(ScenarioContext context) : BaseStep(context)
{
    /*When I navigate to the Premium page
    Then I should see the Premium plans
    When I click the Get Premium Duo button
    Then I should be redirected to the checkout page
    When I enter valid payment details
    Then I should not see any error messages*/

    private readonly Home _homePage = new();
    private readonly Premium _premiumPage = new();
    private readonly Checkout _checkoutPage = new();

    [When("I navigate to the Premium page")]
    public void WhenInavigatetothePremiumpage()
    {
        _homePage.PressPremium();
    }

    [Then("I should see the Premium plans")]
    public void ThenIshouldseethePremiumplans()
    {
        _premiumPage.ArePlansVisible().Should().BeTrue("List of Plans should be visible");
    }

    [When("I click the Get Premium Duo button")]
    public void WhenIclicktheGetPremiumDuobutton()
    {
        _premiumPage.ClickPurchaseDuo();
    }

    [Then("I should be redirected to the checkout page")]
    public void ThenIshouldberedirectedtothecheckoutpage()
    {
        _checkoutPage.IsCheckoutVisible().Should().BeTrue("Checkout should be visible");
    }

    [When("I enter valid payment details")]
    public void WhenIentervalidpaymentdetails()
    {
        _checkoutPage.InputCreditCard();
    }

    [Then("I should not see any error messages")]
    public void ThenIshouldnotseeanyerrormessages()
    {
        _checkoutPage.IsCheckoutVisible().Should().BeFalse("Error message should not be visible");
    }
}