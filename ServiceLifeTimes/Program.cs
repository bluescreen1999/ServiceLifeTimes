using ServiceLifeTimes.Services.Singleton;
using ServiceLifeTimes.Services.Transient;
using ServiceLifeTimes.Services.Scoped;
using ServiceLifeTimes.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ITransientDateTimeService, DateTimeService>();
builder.Services.AddScoped<IScopedDateTimeService, DateTimeService>();
builder.Services.AddSingleton<ISingletonDateTimeService, DateTimeService>();

builder.Services.AddTransient<ApplicationLogger>();

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
