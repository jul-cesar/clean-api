using OneReview.Services;

var builder = WebApplication.CreateBuilder(args);
{
    // Configure servicecs (Dependency Injection)
    builder.Services.AddControllers();
    builder.Services.AddScoped<ProductService>();
}
var app = builder.Build();

{
 // Configuure request pipiline
 app.MapControllers();  
}

app.Run();

