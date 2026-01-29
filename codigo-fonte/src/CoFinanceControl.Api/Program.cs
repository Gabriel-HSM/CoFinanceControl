var builder = WebApplication.CreateBuilder(args);

//Controller
builder.Services.AddControllers();

//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Swagger x2
app.UseSwagger();
app.UseSwaggerUI();


app.Run();
