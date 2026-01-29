var builder = WebApplication.CreateBuilder(args);

//Swagger
builder.Services;
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();
//Registrar App + infra
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>(); 

var app = builder.Build();

//Swagger
app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();
app.MapControllers();
app.Run();
