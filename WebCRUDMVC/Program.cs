using Microsoft.EntityFrameworkCore;
using WebCRUDMVC.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//string de conexão com o Banco de Dados
builder.Services.AddDbContext<Contexto>
(options => options.UseSqlServer("Data Source=DESKTOP-L1791ID\\SQLEXPRESS;Initial Catalog=CRUD_MVC_SQL_CADADV1;Integrated Security=True"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
