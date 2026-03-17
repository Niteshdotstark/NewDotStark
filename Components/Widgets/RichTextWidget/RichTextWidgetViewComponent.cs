using Kentico.PageBuilder.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace DotStark.Components.Widgets
{
    public class RichTextWidgetViewComponent : ViewComponent
    {
        public const string IDENTIFIER = "DotStark.RichTextWidget";

        public IViewComponentResult Invoke(ComponentViewModel<RichTextWidgetProperties> cmsComponent)
        {
            var vm = new RichTextWidgetViewModel
            {
                Text = cmsComponent.Properties.Text
            };
            return View("~/Components/Widgets/RichTextWidget/_RichTextWidget.cshtml", vm);
        }
    }
}
