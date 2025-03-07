using DesafioWeb;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirTudo", policy =>
    {
        policy.WithOrigins("http://127.0.0.1:5500", "http://localhost:5500") //Caso necessário, alterar para a porta designada do Live Server de index.html
              .AllowAnyMethod()
              .AllowAnyHeader()
              .AllowCredentials();
    });
});


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddHttpClient<ViaCepService>();
builder.Services.AddScoped<ViaCepService>();
builder.Services.AddSingleton<EnderecoRepository>();

var app = builder.Build();

app.UseCors("PermitirTudo"); 

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
