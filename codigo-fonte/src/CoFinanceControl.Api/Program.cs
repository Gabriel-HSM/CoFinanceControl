var builder = WebApplication.CreateBuilder(args);

//Controller
builder.Services.AddControllers();

//Swagger
builder.Services.AddEndpointsApiExplorer();
var app = builder.Build();



app.Run();
