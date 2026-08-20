using System.Text.Json;

namespace AutomaticShutdown;

public class AppConfig
{
    public int WorkDurationMinutes { get; set; } = 570;
    public int ShutdownCountdownMinutes { get; set; } = 2;
    public List<int> DelayOptions { get; set; } = [5, 10, 15, 30];
    public string LogPath { get; set; } = "./StartTime.log";
    public bool EnableTrayCountdown { get; set; } = true;

    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        WriteIndented = true
    };

    private static string ConfigPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");

    public static AppConfig Load()
    {
        if (!File.Exists(ConfigPath))
        {
            var defaultConfig = new AppConfig();
            defaultConfig.Save();
            return defaultConfig;
        }

        try
        {
            var json = File.ReadAllText(ConfigPath);
            return JsonSerializer.Deserialize<AppConfig>(json, JsonOptions) ?? new AppConfig();
        }
        catch
        {
            return new AppConfig();
        }
    }

    public void Save()
    {
        var json = JsonSerializer.Serialize(this, JsonOptions);
        File.WriteAllText(ConfigPath, json);
    }
}
