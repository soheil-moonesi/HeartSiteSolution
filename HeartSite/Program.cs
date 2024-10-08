using HeartSite;
using HeartSite.DAL;
using Microsoft.EntityFrameworkCore;
using HeartSite.DAL;
using static System.Runtime.InteropServices.JavaScript.JSType;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<HeartSiteDataBase>(options =>
{
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
}
);

builder.Services.AddDbContext<TestDataBase>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Data Source=.;Initial Catalog=TestDataBase;Integrated Security=True;TrustServerCertificate=True"));
});

//using (var context = new TestDataBase(new DbContextOptions<TestDataBase>()))
//{
//    context.Database.EnsureDeleted();
//    context.Database.EnsureCreated();
//}


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
