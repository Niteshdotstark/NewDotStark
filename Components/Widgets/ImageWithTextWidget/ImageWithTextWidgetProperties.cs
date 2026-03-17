using Kentico.PageBuilder.Web.Mvc;
using Kentico.Xperience.Admin.Base.FormAnnotations;

namespace DotStark.Components.Widgets
{
    public class ImageWithTextWidgetProperties : IWidgetProperties
    {
        [TextInputComponent(Label = "Heading", Order = 1)]
        public string Heading { get; set; } = "Section Heading";

        [TextAreaComponent(Label = "Text", Order = 2)]
        public string Text { get; set; } = "Supporting text content goes here.";

        [TextInputComponent(Label = "Image URL", Order = 3)]
        public string ImageUrl { get; set; } = "";

        [TextInputComponent(Label = "Image Alt Text", Order = 4)]
        public string ImageAlt { get; set; } = "";

        [DropDownComponent(Label = "Image Position", Order = 5,
            Options = "left;Left\nright;Right")]
        public string ImagePosition { get; set; } = "left";

        [TextInputComponent(Label = "Button Text", Order = 6)]
        public string ButtonText { get; set; } = "";

        [TextInputComponent(Label = "Button URL", Order = 7)]
        public string ButtonUrl { get; set; } = "#";
    }
}
