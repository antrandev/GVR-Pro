using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Utilities
{
    public static class Common
    {
        public static string LanguageCode(string languageCode)
        {
            string DefaultLanguage = "vi-VN";
            if (!string.IsNullOrEmpty(languageCode))
            {
                if (languageCode == "VN")
                {
                    return DefaultLanguage;
                }
                else if (languageCode == "en")
                {
                    return "en";
                }
            }
            return DefaultLanguage;
        }



    }
}
