using LanguageManagement.Application;
using LanguageManagement.Application.Configuration;
using LanguageManagement.Application.Interfaces;
using LanguageManagement.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<CultureApiSettings>(builder.Configuration.GetSection("ApiSettings")); // Corrected to "ApiSettings" as per file
builder.Services.AddHttpClient<ICultureService, CultureService>();
// builder.Services.AddScoped<ICultureService, CultureService>(); // This line is effectively covered by AddHttpClient<ICultureService, CultureService>

builder.Services.AddScoped<ILanguageMediator, LanguageMediator>(); // Add this line

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient<ExternalApiService>();


// builder.Services.Configure<CultureApiSettings>( //This line is moved up
//     builder.Configuration.GetSection("ApiSettings"));
// builder.Services.AddHttpClient<ICultureService, CultureService>(); //This line is moved up
builder.Services.AddAutoMapper(typeof(Program).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
