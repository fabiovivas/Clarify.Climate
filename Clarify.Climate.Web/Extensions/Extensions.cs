using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Clarify.Climate.Web.helpers
{
    public static class Extensions
    {
        public static String ToDateCultureInfo(this DateTime obj)
        {
            var convertedDate = obj.ToString("dd/MM/yyyy, dddd");
            var dateArray = convertedDate.Split(',');
            var result = $"{dateArray[0]},{dateArray[1].Split('-')[0]}";
            return result;
        }
    }
}