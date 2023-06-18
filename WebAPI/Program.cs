using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IUserDal, EfUserDal>();
builder.Services.AddScoped<IBrandDal , EfBrandDal>();
builder.Services.AddScoped<IColorDal , EfColorDal>();
builder.Services.AddScoped<ICustomerDal , EfCustomerDal>();
builder.Services.AddScoped<IRentalDal , EfRentalDal>();
builder.Services.AddScoped<IUserDal , EfUserDal>();


builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IBrandService, BrandManager>();
builder.Services.AddScoped<IColorService, ColorManager>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();
builder.Services.AddScoped<IRentalService, RentalManager>();
builder.Services.AddScoped<IUserService, UserManager>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
