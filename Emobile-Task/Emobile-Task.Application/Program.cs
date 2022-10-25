using Emobile_Task.DAL.Extentions;
using Emobile_Task.Service.Extentions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.LoadDataLayerExtentions(builder.Configuration);
builder.Services.LoadServiceLayerExtentions();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
