using Kentico.PageBuilder.Web.Mvc;
using Kentico.Xperience.Admin.Base.FormAnnotations;

namespace DotStark.Components.Widgets
{
    public class CardWidgetProperties : IWidgetProperties
    {
        [TextInputComponent(Label = "Title", Order = 1)]
        public string Title { get; set; } = "Card Title";

        [TextAreaComponent(Label = "Description", Order = 2)]
        public string Description { get; set; } = "Card description goes here.";

        [TextInputComponent(Label = "Link URL", Order = 3)]
        public string LinkUrl { get; set; } = "#";

        [TextInputComponent(Label = "Link Text", Order = 4)]
        public string LinkText { get; set; } = "Learn More";

        [TextInputComponent(Label = "Icon CSS Class", Order = 5)]
        public string IconClass { get; set; } = "icon-star";
    }
}
