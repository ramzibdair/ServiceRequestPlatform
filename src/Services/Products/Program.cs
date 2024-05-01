var builder = WebApplication.CreateBuilder(args);
//add DI 
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//add pipeline 
app.Run();
