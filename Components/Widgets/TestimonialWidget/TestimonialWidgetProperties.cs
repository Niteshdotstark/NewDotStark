using Kentico.PageBuilder.Web.Mvc;
using Kentico.Xperience.Admin.Base.FormAnnotations;

namespace DotStark.Components.Widgets
{
    public class TestimonialWidgetProperties : IWidgetProperties
    {
        [TextAreaComponent(Label = "Quote", Order = 1)]
        public string Quote { get; set; } = "This is an amazing product that changed the way we work.";

        [TextInputComponent(Label = "Author Name", Order = 2)]
        public string AuthorName { get; set; } = "John Doe";

        [TextInputComponent(Label = "Author Title", Order = 3)]
        public string AuthorTitle { get; set; } = "CEO, Company";

        [TextInputComponent(Label = "Author Image URL", Order = 4)]
        public string AuthorImageUrl { get; set; } = "";

        [DropDownComponent(Label = "Theme", Order = 5,
            Options = "light;Light\ndark;Dark")]
        public string Theme { get; set; } = "light";
    }
}
