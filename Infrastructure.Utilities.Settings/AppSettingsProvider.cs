using System;

namespace Infrastructure.Settings
{
    public static class AppSettingsProvider
    {
        public static string ConnectionString { get; set; }
        public static string languageCode { get; set; }
        public static string CookieslanguageCode { get; set; }
    }
}
