using Kentico.PageBuilder.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DotStark.Components.Widgets
{
    public class InnovationWidgetViewComponent : ViewComponent
    {
        public const string IDENTIFIER = "DotStark.InnovationWidget";

        public IViewComponentResult Invoke(ComponentViewModel<InnovationWidgetProperties> cmsComponent)
        {
            var p = cmsComponent.Properties;
            var vm = new InnovationWidgetViewModel
            {
                SectionLabel = p.SectionLabel,
                Heading = p.Heading,
                Description = p.Description,
                ButtonText = p.ButtonText,
                ButtonUrl = p.ButtonUrl,
                BackgroundColor = p.BackgroundColor,
                Examples = new[] { p.Example1, p.Example2, p.Example3, p.Example4 }
                    .Where(e => !string.IsNullOrEmpty(e))
                    .ToArray()
            };
            return View("~/Components/Widgets/InnovationWidget/_InnovationWidget.cshtml", vm);
        }
    }
}
