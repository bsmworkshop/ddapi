using SteelDonkey.WebApi.Configurations;

var builder = WebApplication.CreateBuilder(args);

var logger = Log.Logger = new LoggerConfiguration()
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .CreateLogger();

logger.Information("Starting web host");

builder.Host.UseSerilog((_, config) => config.ReadFrom.Configuration(builder.Configuration));

var appLogger = new SerilogLoggerFactory(logger)
    .CreateLogger<Program>();

builder.Services.AddServiceConfigs(appLogger, builder);

builder.Services.AddFastEndpoints()
    .SwaggerDocument(o =>
    {
        o.ShortSchemaNames = true;
    });

var app = builder.Build();

await app.UseAppMiddleware();

app.Run();

public partial class Program { }