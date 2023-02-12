using MvcApp.Servis;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

//new OracleDatabase();
//builder.Services.AddTransient<IDatabase, OracleDatabase>();

//request -> response, yoksa, new OracleDatabase(), varsa varolaný verecek
builder.Services.AddScoped<IDatabase, OracleDatabase>();

//singleton
//builder.Services.AddSingleton<IDatabase, OracleDatabase>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
