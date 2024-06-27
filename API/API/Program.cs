using API.BusinessLogicLayer.Mapping;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDatabaseAndRepositories(builder.Configuration);

builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<UserMappingProfile>();
    cfg.AddProfile<ProductMappingProfile>();
    cfg.AddProfile<CategoryMappingProfile>();
    cfg.AddProfile<OrdersMappingProfile>();
    cfg.AddProfile<OrderItemsMappingProfile>();
});

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

app.UseAuthorization();

app.MapControllers();

app.Run();
