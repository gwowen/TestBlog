using System;
using TestBlog.Core.Objects;
using System.Configuration;
using System.Web.Mvc;

namespace TestBlog
{
    public static class Extensions
    {
        public static string ToConfigLocalTime(this DateTime utcDt)
        {
            ///<summary>
            ///Convert the passed DateTime from UTC timezone to configured timezone in web.config
            ///</summary>
            /// <param name="utcDT"></param>
            /// <returns></returns>
            var istTZ = TimeZoneInfo.FindSystemTimeZoneById(ConfigurationManager.AppSettings["Timezone"]);
            return String.Format("{0} ({1})", TimeZoneInfo.ConvertTimeFromUtc(utcDt, istTZ).ToShortDateString(), 
                ConfigurationManager.AppSettings["TimezoneAbbr"]);
        }
    }
}