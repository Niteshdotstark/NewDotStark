using Kentico.PageBuilder.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace DotStark.Components.Widgets
{
    public class ContactUsWidgetViewComponent : ViewComponent
    {
        public const string IDENTIFIER = "DotStark.ContactUsWidget";

        public IViewComponentResult Invoke(ComponentViewModel<ContactUsWidgetProperties> cmsComponent)
        {
            var p = cmsComponent.Properties;
            var vm = new ContactUsWidgetViewModel
            {
                Heading = p.Heading,
                Description = p.Description,
                PrimaryButtonText = p.PrimaryButtonText,
                PrimaryButtonUrl = p.PrimaryButtonUrl,
                SecondaryButtonText = p.SecondaryButtonText,
                SecondaryButtonUrl = p.SecondaryButtonUrl,
                BackgroundColor = p.BackgroundColor
            };
            return View("~/Components/Widgets/ContactUsWidget/_ContactUsWidget.cshtml", vm);
        }
    }
}
