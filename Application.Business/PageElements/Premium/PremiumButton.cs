namespace Application.Business.PageElements.Premium;

using Application.Model.PageElements;
using Application.Model.PageElements.Login;

public class PremiumButton(ButtonControl model) : Button(model)
{
    public override void Click() => model.Click();
}