using Microsoft.Extensions.Configuration;
using options_test;

Console.WriteLine("Hello, World!");

IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddEnvironmentVariables()
    .Build();

// Bind settings
var treKeyCloakSettings = new TreKeyCloakSettings();
configuration.Bind(nameof(treKeyCloakSettings), treKeyCloakSettings);

Console.WriteLine($"Authority: {treKeyCloakSettings.Authority}");
