var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
/*
Dependency Injection pattern
if user wants put the service during the dev register on here

*/

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

//app.UseHttpsRedirection(); //-> we are not going to use for local env this is mostly for actual product level to use HTTP


app.UseAuthorization();

app.MapControllers(); //-> when the controller hits, check the endpoint and run the controller.

app.Run();
