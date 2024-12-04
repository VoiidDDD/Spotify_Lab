namespace Application.Model.Pages;

using Application.Model.PageElements;

public class PremiumPage : ModelBase
{
    private const string listOfPlansCSS = "div[data-testid='storefront']";
    private const string planCardsCSS = "div[data-testid='plan-card']";
    private const string buttonCSS = "button[data-encore-id='buttonPrimary']";
    public PremiumPage()
    {
        
    }

    public static ModelControlBase ListOfCards => new(Driver.FindElementByCss(listOfPlansCSS));
    public static ModelControlBase PremiumDuoCard => new(ListOfCards.element.FindElementsByCss(planCardsCSS).ElementAt(2));
    public static ButtonControl PremiumDuoButton => new(PremiumDuoCard.element.FindElementByCss(buttonCSS));
}
