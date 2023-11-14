using API.Initializers;
using Application.UseCases.Commands.Cart;
using Application.UseCases.Commands.Category;
using Application.UseCases.Commands.Order;
using Application.UseCases.Commands.Product;
using Application.UseCases.Commands.Supplier;
using Application.UseCases.Commands.User;
using DataAccess;
using Implementation;
using Implementation.Commands.Cart;
using Implementation.Commands.Category;
using Implementation.Commands.Order;
using Implementation.Commands.Product;
using Implementation.Commands.Supplier;
using Implementation.Commands.User;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<WebShopContext>();
//builder.Services.AddTransient<JwtManager>();
builder.Services.AddTransient<UseCaseHandler>();

builder.Services.AddTransient<IAddUserCommand, EfAddUserCommand>();
builder.Services.AddTransient<IUpdateUserCommand, EfUpdateUserCommand>();
builder.Services.AddTransient<IDeleteUserCommand, EfDeleteUserCommand>();
builder.Services.AddTransient<IAddProductCommand, EfAddProductCommand>();
builder.Services.AddTransient<IUpdateProductCommand, EfUpdateProductCommand>();
builder.Services.AddTransient<IDeleteProductCommand, EfDeleteProductCommand>();
builder.Services.AddTransient<IAddCategoryCommand, EfAddCategoryCommand>();
builder.Services.AddTransient<IUpdateCategoryCommand, EfUpdateCategoryCommand>();
builder.Services.AddTransient<IDeleteCategoryCommand, EfDeleteCategoryCommand>();
builder.Services.AddTransient<IAddSupplierCommand, EfAddSupplierCommand>();
builder.Services.AddTransient<IUpdateSupplierCommand, EfUpdateSupplierCommand>();
builder.Services.AddTransient<IDeleteSupplierCommand, EfDeleteSupplierCommand>();
builder.Services.AddTransient<IAddCartCommand, EfAddCartCommand>();
builder.Services.AddTransient<IUpdateCartCommand, EfUpdateCartCommand>();
builder.Services.AddTransient<IDeleteCartCommand, EfDeleteCartCommand>();
builder.Services.AddTransient<IAddOrderCommand, EfAddOrderCommand>();
builder.Services.AddTransient<IUpdateOrderCommand, EfUpdateOrderCommand>();
builder.Services.AddTransient<IDeleteOrderCommand, EfDeleteOrderCommand>();

builder.Services.RegisterApplicationServices();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureMiddleware();
app.RegisterEndpoints();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
