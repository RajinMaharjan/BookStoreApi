using Bookstore.Infrastructure.Configurations;
using Bookstore.Infrastructure.Persistence.Configurations;
using Infrastructure.Configurations;
using Serilog;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Adding logger (Serilog)
var logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);
builder.Logging.AddConsole();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddJWTConfigurationServices(builder.Configuration);
builder.Services
    .AddControllers()
    .AddNewtonsoftJson()
    .AddXmlDataContractSerializerFormatters(); ;
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(options =>
{
    options.AddPolicy(
        "CorsPolicy",
        builder=> builder
        .WithOrigins("http://localhost:4200")
        .AllowAnyMethod()
        .AllowAnyHeader()
        );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseStaticFiles();

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
