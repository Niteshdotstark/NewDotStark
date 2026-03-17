using Kentico.PageBuilder.Web.Mvc;
using Kentico.Xperience.Admin.Base.FormAnnotations;

namespace DotStark.Components.Widgets
{
    public class ContactUsWidgetProperties : IWidgetProperties
    {
        [TextInputComponent(Label = "Heading", Order = 0)]
        public string Heading { get; set; } = "Start Your Digital Transformation";

        [TextAreaComponent(Label = "Description", Order = 1)]
        public string Description { get; set; } = "Partner with DotStark to design and build scalable digital platforms powered by AI, Kentico, and Microsoft technologies.";

        [TextInputComponent(Label = "Primary Button Text", Order = 2)]
        public string PrimaryButtonText { get; set; } = "Book a Consultation";

        [TextInputComponent(Label = "Primary Button URL", Order = 3)]
        public string PrimaryButtonUrl { get; set; } = "#";

        [TextInputComponent(Label = "Secondary Button Text", Order = 4)]
        public string SecondaryButtonText { get; set; } = "Contact Us";

        [TextInputComponent(Label = "Secondary Button URL", Order = 5)]
        public string SecondaryButtonUrl { get; set; } = "#";

        [TextInputComponent(Label = "Background Color", Order = 6)]
        public string BackgroundColor { get; set; } = "#1b54ff";
    }
}
