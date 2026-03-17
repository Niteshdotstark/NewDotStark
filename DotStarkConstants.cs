namespace DotStark
{
    internal static class DotStarkConstants
    {
        /// <summary>
        /// Route constraint limiting matches to controllers NOT handled by the content tree router.
        /// Add controller names here as your project grows (pipe-separated).
        /// </summary>
        public const string CONSTRAINT_FOR_NON_ROUTER_PAGE_CONTROLLERS = "HttpErrors";

        public const string DEFAULT_ROUTE_NAME = "default";
        public const string DEFAULT_ROUTE_WITHOUT_LANGUAGE_PREFIX_NAME = "defaultWithoutLanguagePrefix";

        public const string WEBSITE_CHANNEL_NAME = "DotStarkPages";
    }
}
