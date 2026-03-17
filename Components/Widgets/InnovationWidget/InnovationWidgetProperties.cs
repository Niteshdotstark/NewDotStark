using Kentico.PageBuilder.Web.Mvc;
using Kentico.Xperience.Admin.Base.FormAnnotations;

namespace DotStark.Components.Widgets
{
    public class InnovationWidgetProperties : IWidgetProperties
    {
        [TextInputComponent(Label = "Section Label", Order = 0)]
        public string SectionLabel { get; set; } = "Innovation";

        [TextInputComponent(Label = "Heading", Order = 1)]
        public string Heading { get; set; } = "AI-Powered Digital Experience Platforms";

        [TextAreaComponent(Label = "Description", Order = 2)]
        public string Description { get; set; } = "We combine AI intelligence with Kentico's digital experience platform to create websites that understand user behavior, personalize content, and drive measurable growth.";

        [TextInputComponent(Label = "Button Text", Order = 3)]
        public string ButtonText { get; set; } = "Explore Our AI Solutions";

        [TextInputComponent(Label = "Button URL", Order = 4)]
        public string ButtonUrl { get; set; } = "#solutions";

        [TextInputComponent(Label = "Example 1", Order = 5)]
        public string Example1 { get; set; } = "AI-powered content recommendations";

        [TextInputComponent(Label = "Example 2", Order = 6)]
        public string Example2 { get; set; } = "AI chatbot integrations";

        [TextInputComponent(Label = "Example 3", Order = 7)]
        public string Example3 { get; set; } = "Automated personalization";

        [TextInputComponent(Label = "Example 4", Order = 8)]
        public string Example4 { get; set; } = "Smart search using LLMs";

        [TextInputComponent(Label = "Background Color", Order = 9)]
        public string BackgroundColor { get; set; } = "#0a0a0a";
    }
}
