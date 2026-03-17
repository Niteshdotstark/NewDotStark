using Kentico.PageBuilder.Web.Mvc;
using Kentico.Xperience.Admin.Base.FormAnnotations;

namespace DotStark.Components.Widgets
{
    public class HeroImageWidgetProperties : IWidgetProperties
    {
        [TextInputComponent(Label = "Heading", Order = 1)]
        public string Heading { get; set; } = "Hero Heading";

        [TextAreaComponent(Label = "Subheading", Order = 2)]
        public string Subheading { get; set; } = "A short supporting line goes here.";

        [TextInputComponent(Label = "Image URL", Order = 3)]
        public string ImageUrl { get; set; } = "";

        [TextInputComponent(Label = "Button Text", Order = 4)]
        public string ButtonText { get; set; } = "Get Started";

        [TextInputComponent(Label = "Button URL", Order = 5)]
        public string ButtonUrl { get; set; } = "#";

        [DropDownComponent(Label = "Text Alignment", Order = 6,
            Options = "left;Left\ncenter;Center\nright;Right")]
        public string Alignment { get; set; } = "center";
    }
}
