using System.Text.RegularExpressions;

namespace LearnEnglish.API.Extensions
{
    public static class StringExtensions
    {
        public static string ReplaceAccents(this string text)
        {
            return Encoding.UTF8.GetString(Encoding.GetEncoding("ISO-8859-8").GetBytes(text));
        }

        public static string OnlyLettersAndNumbers(this string text)
        {
            return Regex.Replace(text, @"[^a-z0-9]", string.Empty);
        }
    }
}
