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
                var recordedTime = DateTime.Parse(content);
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
            File.WriteAllText(fullPath, now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
        catch
        {
        }

        return now;
    }
}
