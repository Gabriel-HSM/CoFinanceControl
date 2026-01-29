var builder = WebApplication.CreateBuilder(args);

//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Swagger
app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();
app.Run();
