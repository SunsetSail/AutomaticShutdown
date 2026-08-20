namespace AutomaticShutdown;

public static class StartTimeRecorder
{
    public static DateTime RecordOrGetStartTime(string logPath)
    {
        var fullPath = Path.GetFullPath(logPath);
        var directory = Path.GetDirectoryName(fullPath);
        if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }

        if (File.Exists(fullPath))
        {
            try
            {
                var content = File.ReadAllText(fullPath).Trim();
                var recordedTime = ParseLogFile(content);
                if (recordedTime.Date == DateTime.Today)
                {
                    return recordedTime;
                }
            }
            catch
            {
            }
        }

        var now = DateTime.Now;
        try
        {
            WriteLogFile(fullPath, now);
        }
        catch
        {
        }

        return now;
    }

    public static void SaveStartTime(string logPath, DateTime startTime)
    {
        try
        {
            var fullPath = Path.GetFullPath(logPath);
            WriteLogFile(fullPath, startTime);
        }
        catch
        {
        }
    }

    private static DateTime ParseLogFile(string content)
    {
        var lines = content.Split('\n', StringSplitOptions.RemoveEmptyEntries);
        string? dateStr = null;
        string? timeStr = null;

        foreach (var line in lines)
        {
            var trimmed = line.Trim();
            if (trimmed.StartsWith("Date=", StringComparison.OrdinalIgnoreCase))
                dateStr = trimmed[5..];
            else if (trimmed.StartsWith("StartTime=", StringComparison.OrdinalIgnoreCase))
                timeStr = trimmed[10..];
        }

        if (!string.IsNullOrEmpty(timeStr))
            return DateTime.Parse(timeStr);

        if (!string.IsNullOrEmpty(dateStr))
            return DateTime.Parse(dateStr);

        return DateTime.Parse(content);
    }

    private static void WriteLogFile(string filePath, DateTime time)
    {
        var content = $"Date={time:yyyy-MM-dd}\nStartTime={time:yyyy-MM-dd HH:mm:ss}";
        File.WriteAllText(filePath, content);
    }
}
