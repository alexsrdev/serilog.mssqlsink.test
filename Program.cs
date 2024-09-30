using Serilog;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MyDbContext>();
builder.Host.UseSerilog((hostingContext, loggerConfiguration) =>
    loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration));

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.Run();
