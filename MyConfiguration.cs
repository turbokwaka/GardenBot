namespace GardenBot;

public class MyConfiguration
{
    public string TelegramToken { get; }
    public string ApiUrl { get; }
    public List<string> ApiTokens { get; }

    public MyConfiguration()
    {
        // accessing configuration file
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        // getting data
        TelegramToken = configuration["MyConfiguration:TelegramToken"]!;
        ApiUrl = configuration["MyConfiguration:ApiUrl"]!;
        ApiTokens = configuration.GetSection("MyConfiguration:ApiTokens").GetChildren()
            .Select(token => token.Value)
            .ToList()!;
    }
}