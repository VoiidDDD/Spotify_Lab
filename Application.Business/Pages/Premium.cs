namespace Application.Business.Pages;

using Application.Model.Pages;
using Application.Business.PageElements.Login;
using Application.Business.PageElements.Library;
using Application.Business.PageElements.Player;
using Application.Model;
using Common.Utils.ExceptionWrapper;
using Common.Utils.Waiter;

public class Premium : BusinessBase
{
    public Premium() : base(new PremiumPage()) { }
    public Premium(PremiumPage premiumPage) : base(premiumPage) { }

    public void ClickPurchaseDuo()
    {
        PremiumPage.PremiumDuoButton.Click();

    }
    public bool ArePlansVisible()
    {
        return PremiumPage.ListOfCards.IsVisible;
    }
}