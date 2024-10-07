using Microsoft.EntityFrameworkCore;
using System;
using Test1_Blue_Api.Data;
using AutoMapper;
using Test1_Blue_Api.Models;
using Microsoft.AspNetCore.Identity;
using Test1_Blue_Api.Extention;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGenJwtAuth();

builder.Services.AddAutoMapper(typeof(MappingProfile));







builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddCustomJwtAuth(builder.Configuration);




builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowVueApp",
        builder => builder.AllowAnyOrigin() // Replace with your Vue app's URL for production
        .AllowAnyMethod()
        .AllowAnyHeader());
});
/******************************** Microsoft.AspNetCore.Cors package **********************************************/
/*
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder => builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});
*/
/******************************************************************************/


var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var configuration = services.GetRequiredService<IConfiguration>();
        await DataSeeder.SeedRolesAndAdminAsync(services, configuration);
    }
    catch (Exception ex)
    {
        // Log the exception or handle it as needed
        Console.WriteLine($"An error occurred while seeding the database: {ex.Message}");
    }
}






// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
// Use CORS policy
app.UseCors("AllowVueApp");

// Configure other middleware...
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
//app.UseAuthorization();

//app.UseCors("AllowAllOrigins");
app.MapControllers();

app.Run();