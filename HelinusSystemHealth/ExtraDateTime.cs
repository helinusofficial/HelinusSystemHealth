using System;
using System.Collections.Generic;
using System.Text;

namespace HelinusPingUtility
{
    internal class ExtraDateTime
    {
        public static string ConvertDateTimeToFileName(DateTime date)
        {
            return date.ToString().Replace("/", "-").Replace(":", "-");
        }
        public static string ConvertDateTimeToDate(DateTime date)
        {
            string temp = date.ToString();
            return temp.Remove(temp.IndexOf(" "), temp.Length - temp.IndexOf(" ")).Replace("/", "-");
        }
        public string TranslateTime(DateTime dateSecond, DateTime dateFirst)
        {
            string result = string.Empty;

            try
            {
                TimeSpan span = (dateSecond - dateFirst);
                if (span.Days >= 30)
                    return dateFirst.ToString();

                else if (span.Days < 30 && span.Days > 0)
                    result = String.Format("{0} day(s), {1} hour(s), {2} minute(s)", span.Days, span.Hours, span.Minutes) + " ago";
                else if (span.Days == 0 && span.Hours > 0)
                    result = String.Format("{0} hour(s), {1} minute(s)", span.Hours, span.Minutes) + " ago";
                else if (span.Days == 0 && span.Hours == 0 && span.Minutes > 0)
                    result = String.Format("{0} minute(s)", span.Minutes) + " ago";
                else if (span.Seconds > 5)
                    result = String.Format("{0} Seconds a go", span.Seconds) + " ago";
                else
                    result = "few seconds ago";

            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public string TranslateTimeByLanguage(DateTime dateSecond, DateTime dateFirst, string dayCulture, string hourCulture, string minuteCulture, string secondCulture, string ago, string fewsecondago)
        {
            string result = string.Empty;

            try
            {
                TimeSpan span = (dateSecond - dateFirst);

                if (span.Days >= 30)
                    return dateFirst.ToString();
                else if (span.Days < 30 && span.Days > 0)
                    result = String.Format("{0} {1}, {2} {3}, {4} {5}", span.Days, dayCulture, span.Hours, hourCulture, span.Minutes, minuteCulture) + " " + ago;
                else if (span.Days == 0 && span.Hours > 0)
                    result = String.Format("{0} {1}, {2} {3}", span.Hours, hourCulture, span.Minutes, minuteCulture) + " " + ago;
                else if (span.Days == 0 && span.Hours == 0 && span.Minutes > 0)
                    result = String.Format("{0} {1}", span.Minutes, minuteCulture) + " " + ago;
                else if (span.Seconds > 5)
                    result = String.Format("{0} {1}", span.Seconds, secondCulture) + " " + ago;
                else
                    result = fewsecondago;

            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public string TranslateTimeToMajorDateTimeByLanguage(DateTime dateSecond, DateTime dateFirst, string monthCulture, string yesterdayCulture, string daybeforeYesterday,
             string dayCulture, string hourCulture, string minuteCulture, string secondCulture, string ago, string fewsecondago)
        {
            string result = string.Empty;

            try
            {
                TimeSpan span = (dateSecond - dateFirst);

                if (span.Days >= 30)

                    return result = String.Format("{0} {1}", span.Days / 30, monthCulture) + " " + ago;
                else if (span.Days < 30 && span.Days > 0)
                {
                    if (span.Days == 1)
                        result = yesterdayCulture;
                    else if (span.Days == 2)
                        result = daybeforeYesterday;
                    else
                        result = String.Format("{0} {1}", span.Days, dayCulture) + " " + ago;
                }
                else if (span.Days == 0 && span.Hours > 0)
                    result = String.Format("{0} {1}", span.Hours, hourCulture) + " " + ago;
                else if (span.Days == 0 && span.Hours == 0 && span.Minutes > 0)
                    result = String.Format("{0} {1}", span.Minutes, minuteCulture) + " " + ago;
                else if (span.Seconds > 5)
                    result = String.Format("{0} {1}", span.Seconds, secondCulture) + " " + ago;
                else
                    result = fewsecondago;

            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}
