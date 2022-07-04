using Token.Inject;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoInject();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();