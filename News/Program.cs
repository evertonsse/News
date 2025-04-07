using Microsoft.EntityFrameworkCore;
using News.Components;
using Pomelo.EntityFrameworkCore.MySql;
using MudBlazor.Services;
using News;
using News.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMudServices();

//Dependecies Injections
builder.Services.AddScoped<CategoryServices>();
builder.Services.AddScoped<PostServices>();

builder.Services.AddDbContextFactory<AppDbContext>(options =>
 options.
 UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
    )
); 

var app = builder.Build();

if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error", createScopeForErrors: true);

    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
app.Run();
