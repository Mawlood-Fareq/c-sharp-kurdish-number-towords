using System;

namespace KurdishNumberToWords
{
    public class KurdishNumber
    {
        public string Convert(long number, int level = 0)
        {
            string[] ones = { "یەک", "دوو", "سێ", "چوار", "پێنج", "شەش", "حەوت", "هەشت", "نۆ" };
            string[] ten = { "ده", "یازده", "دوازدە", "سیازده", "چوارده", "پازده", "شازده", "حەڤده", "هەژده", "نۆزده" };
            string[] tens = { "بیست", "سی", "چل", "پەنجا", "شەست", "حەفتا", "هەشتا", "نەوەد" };
            string[] hundreds = { "سەد", "دوو سەد", "سێ سەد", "چوار سەد", "پێنج سەد", "شەش سەد", "حەوت سەد", "هەشت سەد", "نۆ سەد" };

            var result = "";

            if (number == null)
                return "";

            if (number < 0)
            {
                number = number * -1;
                return "سالب " + Convert(number, level);
            }

            if (number == 0)
            {
                if (level == 0)
                {
                    return "سفر";
                }
                else
                {
                    return "";
                }
            }

            if (level > 0)
            {
                result += " و ";
                level -= 1;
            }

            if (number < 10)
            {
                result += ones[number - 1];
            }
            else if (number < 20)
            {
                result += ten[number - 10];
            }
            else if (number < 100)
            {
                result += tens[(number / 10) - 2] + Convert(number % 10, level + 1);
            }
            else if (number < 1000)
            {
                result += hundreds[(number / 100) - 1] + Convert(number % 100, level + 1);
            }
            else if (number < 1000000)
            {
                result += (number / 1000 < 2 ? "" : Convert((number / 1000), level)) + " هەزار" + Convert(number % 1000, level + 1);
            }
            else if (number < 1000000000)
            {
                result += Convert((number / 1000000), level) + " ملیۆن" + Convert(number % 1000000, level + 1);
            }
            else if (number < 1000000000000)
            {
                result += Convert((number / 1000000000), level) + " میلیارد" + Convert(number % 1000000000, level + 1);
            }
            else if (number < 1000000000000000)
            {
                result += Convert((number / 1000000000000), level) + " تریلیۆن" + Convert(number % 1000000000000, level + 1);
            }

            return result;

        }

        public string ConvertCurrency(double number, string currencyUnit = "دینار", string decimalUnit = "فلس")
        {
            var _split = number.ToString().Split('.');

            if (_split.Length > 1)
            {
                return $"{Convert(Int32.Parse(_split[0]))} {currencyUnit} و {Convert(Int32.Parse(_split[1]))} { decimalUnit}";
            }
            else
            {
                return $"{Convert(Int32.Parse(_split[0]))} {currencyUnit}";
            }
        }
    }


}
