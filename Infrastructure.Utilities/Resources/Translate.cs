using Infrastructure.Security;
using Infrastructure.Settings;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Web;
namespace Infrastructure.Utilities.Resources
{
    public static class Translate
    {
        public static string TranslateString(this string value, string languageCode)
        {
            var key = new TranslateItem(value, languageCode);
            return key.Value;
        }
        public static string TranslateString(this string value)
        {
            var key = new TranslateItem(value);
            return key.Value;
        }
    }

    public class TranslateItem
    {
        private string path = "Infrastructure.Utilities.Resources.Strings";
        public string Value { get; set; }
        public TranslateItem(string key)
        {
            var language = Common.LanguageCode(AppSettingsProvider.languageCode);
            if (!string.IsNullOrEmpty(AppSettingsProvider.CookieslanguageCode))
            {
                language = Common.LanguageCode(AppSettingsProvider.CookieslanguageCode);
            }
            this.Value = SelectLaguage(key, language);
        }

        public TranslateItem(string key, string languageCode)
        {
            this.Value = SelectLaguage(key, languageCode);
        }
        private string SelectLaguage(string key, string languageCode)
        {
            try
            {
                ResourceManager rm = new ResourceManager(path,
                         System.Reflection.Assembly.GetExecutingAssembly());
                System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo(languageCode);
                return rm.GetString(key, ci);
            }
            catch (Exception e)
            {
                var x = e.Message;
                return null;
            }
        }
    }
}
