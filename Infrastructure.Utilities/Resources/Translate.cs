using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Utilities.Resources
{
    public static class Translate
    {
        public static TranslateItem TranslateString(this string value, string languageCode)
        {
            return new TranslateItem(value, languageCode);
        }
        public static string TranslateString(this string value)
        {
            var key = new TranslateItem(value);
            return key.Value;
        }
    }

    public class TranslateItem
    {
        public string Value { get; set; }

        public TranslateItem(string key)
        {
            var language = "en";
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
                ResourceManager rm = new ResourceManager("Infrastructure.Utilities.Resources.Strings",
                         System.Reflection.Assembly.GetExecutingAssembly());
                System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo(languageCode);
                return rm.GetString(key, ci);
            }
            catch(Exception e)
            {
               var x= e.Message;
                return null;
            }
        }
    }
}
