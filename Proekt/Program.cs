using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseDefaultFiles(); 
app.UseStaticFiles();   
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();  
app.MapFallbackToFile("index.html");
app.Run();