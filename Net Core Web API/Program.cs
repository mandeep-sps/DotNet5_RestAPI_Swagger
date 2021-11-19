

using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Net_Core_Web_API.CustomSql;
using Net_Core_Web_API.Database;
using Net_Core_Web_API.Interface;
using Net_Core_Web_API.Service;

#region Configure Services
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(setup => setup.SwaggerDoc("v1", new OpenApiInfo()
{
    Description = "Todo web api implementation using Minimal Api in Asp.Net Core",
    Title = "Todo Api",
    Version = "v1",
    Contact = new OpenApiContact()
    {
        Name = "Mandeep Singh",
        Url = new Uri("https://dotnetthoughts.net")
    }
}));

#region Db Connection String

string connString = builder.Configuration.GetConnectionString("DBConnection");

builder.Services.AddDbContext<OnlineTeachingContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"));

});
// Custom Store procedure Class
builder.Services.AddDbContext<StoredProcedureClass>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"));

});

#endregion

#region Register Srevices
builder.Services.AddScoped<ILectureService, LectureService>();
#endregion

#endregion

#region Configure Method Middle wares

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
       // c.RoutePrefix = String.Empty;
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Demo project API");
        c.InjectStylesheet("/swagger/swagger.css");
        c.ConfigObject.AdditionalItems.Add("syntaxHighlight", false);
        c.ConfigObject.AdditionalItems.Add("theme", "agate");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

#endregion