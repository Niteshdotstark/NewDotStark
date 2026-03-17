namespace DotStark.Components.Widgets
{
    public class InnovationWidgetViewModel
    {
        public string SectionLabel { get; set; } = string.Empty;
        public string Heading { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ButtonText { get; set; } = string.Empty;
        public string ButtonUrl { get; set; } = "#";
        public string[] Examples { get; set; } = [];
        public string BackgroundColor { get; set; } = "#0a0a0a";
    }
}
