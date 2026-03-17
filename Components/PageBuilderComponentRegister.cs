using Dotstark;
using Kentico.PageBuilder.Web.Mvc;

// ── Widgets ──────────────────────────────────────────────────────────────────

[assembly: RegisterWidget(
    identifier: "DotStark.RichTextWidget",
    viewComponentType: typeof(DotStark.Components.Widgets.RichTextWidgetViewComponent),
    name: "Rich Text",
    propertiesType: typeof(DotStark.Components.Widgets.RichTextWidgetProperties),
    Description = "Displays rich HTML text content.",
    IconClass = "icon-l-text")]

[assembly: RegisterWidget(
    identifier: "DotStark.CardWidget",
    name: "Card",
    propertiesType: typeof(DotStark.Components.Widgets.CardWidgetProperties),
    customViewName: "~/Components/Widgets/CardWidget/_CardWidget.cshtml",
    Description = "A card with title, description and a link.",
    IconClass = "icon-rectangle")]

[assembly: RegisterWidget(
    identifier: "DotStark.CTAButtonWidget",
    name: "CTA Button",
    propertiesType: typeof(DotStark.Components.Widgets.CTAButtonWidgetProperties),
    customViewName: "~/Components/Widgets/CTAButtonWidget/_CTAButtonWidget.cshtml",
    Description = "A call-to-action button with configurable style.",
    IconClass = "icon-rectangle-a")]

[assembly: RegisterWidget(
    identifier: "DotStark.HeroImageWidget",
    name: "Hero Image",
    propertiesType: typeof(DotStark.Components.Widgets.HeroImageWidgetProperties),
    customViewName: "~/Components/Widgets/HeroImageWidget/_HeroImageWidget.cshtml",
    Description = "Full-width hero banner with heading, subheading and CTA.",
    IconClass = "icon-picture")]

[assembly: RegisterWidget(
    identifier: "DotStark.TestimonialWidget",
    name: "Testimonial",
    propertiesType: typeof(DotStark.Components.Widgets.TestimonialWidgetProperties),
    customViewName: "~/Components/Widgets/TestimonialWidget/_TestimonialWidget.cshtml",
    Description = "A customer quote with author name and title.",
    IconClass = "icon-right-double-quotation-mark")]

[assembly: RegisterWidget(
    identifier: "DotStark.ImageWithTextWidget",
    name: "Image with Text",
    propertiesType: typeof(DotStark.Components.Widgets.ImageWithTextWidgetProperties),
    customViewName: "~/Components/Widgets/ImageWithTextWidget/_ImageWithTextWidget.cshtml",
    Description = "Side-by-side image and text block.",
    IconClass = "icon-l-cols-2")]

[assembly: RegisterWidget(
    identifier: "DotStark.ContactUsWidget",
    viewComponentType: typeof(DotStark.Components.Widgets.ContactUsWidgetViewComponent),
    name: "Contact Us",
    propertiesType: typeof(DotStark.Components.Widgets.ContactUsWidgetProperties),
    Description = "Full-width CTA section with heading, description and two buttons.",
    IconClass = "icon-phone")]

[assembly: RegisterWidget(
    identifier: "DotStark.InnovationWidget",
    viewComponentType: typeof(DotStark.Components.Widgets.InnovationWidgetViewComponent),
    name: "Innovation",
    propertiesType: typeof(DotStark.Components.Widgets.InnovationWidgetProperties),
    Description = "Dark section with heading, description, CTA and numbered example list.",
    IconClass = "icon-cogwheel")]

// ── Sections ─────────────────────────────────────────────────────────────────

[assembly: RegisterSection(
    identifier: "DotStark.SingleColumnSection",
    name: "Single Column",
    customViewName: "~/Components/Sections/_SingleColumnSection.cshtml",
    IconClass = "icon-square")]
