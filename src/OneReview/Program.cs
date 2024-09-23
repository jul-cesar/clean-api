var builder = WebApplication.CreateBuilder(args);
{
    // Configure servicecs (Dependency Injection)
    builder.Services.AddControllers();
}
var app = builder.Build();

{
 // Configuure request pipiline
 app.MapControllers();  
}

app.Run();

