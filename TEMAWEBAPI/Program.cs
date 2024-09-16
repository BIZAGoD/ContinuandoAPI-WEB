var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<MangaService>();   //CAMBIAMOS EL TIPO DE ALCANCE A SCOPED


builder.Services.AddTransient<MangaRepository>();  

builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

    