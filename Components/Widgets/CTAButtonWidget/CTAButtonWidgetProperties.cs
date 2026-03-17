using Kentico.PageBuilder.Web.Mvc;
using Kentico.Xperience.Admin.Base.FormAnnotations;

namespace DotStark.Components.Widgets
{
    public class CTAButtonWidgetProperties : IWidgetProperties
    {
        [TextInputComponent(Label = "Button Text", Order = 1)]
        public string Text { get; set; } = "Click Here";

        [TextInputComponent(Label = "Link URL", Order = 2)]
        public string LinkUrl { get; set; } = "#";

        [CheckBoxComponent(Label = "Open in New Tab", Order = 3)]
        public bool OpenInNewTab { get; set; }

        [DropDownComponent(Label = "Style", Order = 4,
            Options = "primary;Primary\nsecondary;Secondary\noutline;Outline")]
        public string Style { get; set; } = "primary";
    }
}
