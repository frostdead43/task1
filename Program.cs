var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(); // Controller support
var app = builder.Build();

app.UseDeveloperExceptionPage();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();