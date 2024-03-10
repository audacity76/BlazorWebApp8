using BlazorWebApp8.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

app.UseWhen(ctx => ctx.Request.Path.StartsWithSegments("/blue"), app =>
{
    app.UsePathBase("/blue/");
});

app.UseWhen(ctx => ctx.Request.Path.StartsWithSegments("/green"), app =>
{
    app.UsePathBase("/green/");
});

app.UseRouting();

app.UseRouting();

app.UseStaticFiles();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
