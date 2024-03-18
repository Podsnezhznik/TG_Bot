public class DbSettings
{
    public string ConnectionString { get; set; }
    public int RetryIntervalMs { get; set; }
    public int RetryCount { get; set; }
}