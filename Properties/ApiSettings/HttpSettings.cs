namespace ConfigManagement.Properties.ApiSettings
{
    public class HttpSettings
    {
        public const string Section = nameof(HttpSettings);

        public int NumberOfRetries { get; set; }

        public int TimeoutSeconds { get; set; }
    }
}