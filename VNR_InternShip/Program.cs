using Microsoft.EntityFrameworkCore;
using VNR_InternShip.Action;
using VNR_InternShip.Action.Interface;
using VNR_InternShip.DBContext;
using VNR_InternShip.Service;
using VNR_InternShip.Service.Interface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IKhoaHocAction,KhoaHocAction>();
builder.Services.AddScoped<IKhoaHocService,KhoaHocService>();

// Add services to the container.
builder.Services.AddControllersWithViews();
var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();
builder.Services.AddDbContext<VnrInternShipContext>(item => item.UseSqlServer(configuration.GetConnectionString("CourseConnect")));

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
    //name: "default",
    //pattern: "{controller=KhoaHoc}/{action=ListKhoaHoc}/{id?}",
    name: "myroute",
    pattern: "{controller=KhoaHoc}/{action=ListKhoaHoc}/{id?}");

app.Run();
