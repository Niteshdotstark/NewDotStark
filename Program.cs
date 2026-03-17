using DotStark;
using Dotstark;
using Kentico.Content.Web.Mvc.Routing;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Kentico.Activities.Web.Mvc;
using Kentico.OnlineMarketing.Web.Mvc;
using Microsoft.AspNetCore.Routing;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddKentico(features =>
{
    features.UsePageBuilder(new PageBuilderOptions
    {
        DefaultSectionIdentifier = "DotStark.SingleColumnSection",
        RegisterDefaultSection = false,
        ContentTypeNames = new[]
        {
            Home.CONTENT_TYPE_NAME
        }
    });

    features.UseWebPageRouting();
    features.UseActivityTracking();
    features.UseEmailStatisticsLogging();
    features.UseEmailMarketing();
});

builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.InitKentico();

app.UseStaticFiles();

app.UseCookiePolicy();

app.UseAuthentication();

app.UseKentico();

app.UseAuthorization();

app.UseStatusCodePagesWithReExecute("/error/{0}");

app.Kentico().MapRoutes();

app.MapControllerRoute(
    name: "error",
    pattern: "error/{code}",
    defaults: new { controller = "HttpErrors", action = "Error" }
);

app.MapControllerRoute(
    name: DotStarkConstants.DEFAULT_ROUTE_NAME,
    pattern: $"{{{WebPageRoutingOptions.LANGUAGE_ROUTE_VALUE_KEY}}}/{{controller}}/{{action}}",
    constraints: new
    {
        controller = DotStarkConstants.CONSTRAINT_FOR_NON_ROUTER_PAGE_CONTROLLERS
    }
);

app.MapControllerRoute(
    name: DotStarkConstants.DEFAULT_ROUTE_WITHOUT_LANGUAGE_PREFIX_NAME,
    pattern: "{controller}/{action}",
    constraints: new
    {
        controller = DotStarkConstants.CONSTRAINT_FOR_NON_ROUTER_PAGE_CONTROLLERS
    }
);

app.Run();

