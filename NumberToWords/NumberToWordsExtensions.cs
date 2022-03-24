using System;

namespace NumberToWords
{
    public static class NumberToWordsExtensions
    {
        static string[] ones =  {
            "sıfır",
            "bir",
            "iki",
            "üç",
            "dört",
            "beş",
            "altı",
            "yedi",
            "sekiz",
            "dokuz"
        };
        static string[] tens =  {
            "",
            "on",
            "yirmi",
            "otuz",
            "kırk",
            "elli",
            "altmış",
            "yetmiş",
            "seksen",
            "doksan"
        };
        static string Run(long n)
        {
            string text = "";

            if (n < 0)
                text = "-";
            else if (n >= 1 && n <= 9)
                text = ones[(int)n];
            else if (n >= 10 && n <= 99)
                text = tens[(int)n / 10] + Run((int)n % 10);
            else if (n >= 100 && n <= 999)
            {
                if (n / 100 != 1)
                    text = Run(n / 100);
                text += "yüz" + Run(n % 100);
            }
            else if (n >= 1000 && n <= 999_999)
            {
                if (n / 1000 != 1)
                    text = Run(n / 1000);
                text += "bin" + Run(n % 1000);
            }
            else if (n >= 1_000_000 && n <= 999_999_999)
            {
                text = Run(n / 1_000_000) + "milyon" + Run(n % 1_000_000);
            }
            else if (n >= 1_000_000_000 && n <= 999_999_999_999)
            {
                text = Run(n / 1_000_000_000) + "milyar" + Run(n % 1_000_000_000);
            }
            else if (n >= 1_000_000_000_000 && n <= 999_999_999_999_999)
            {
                text = Run(n / 1_000_000_000_000) + "trilyon" + Run(n % 1_000_000_000_000);
            }
            else if (n >= 1_000_000_000_000_000 && n <= 999_999_999_999_999_999)
            {
                text = Run(n / 1_000_000_000_000_000) + "katrilyon" + Run(n % 1_000_000_000_000_000);
            }
            else if (n >= 1_000_000_000_000_000_000 && n <= 999_999_999_999_999_999_999m)
            {
                text = Run(n / 1_000_000_000_000_000_000) + "kentilyon" + Run(n % 1_000_000_000_000_000_000);
            }
            return text;
        }

        public static string ConvertToWords(long val)
        {
            if (val == 0)
                return ones[0];
            return Run(val);
        }

        public static string ConvertToTurkisLiras(decimal val)
        {
            string textLiras = "";
            string textPenny = "";

            var liras = Math.Round(val, MidpointRounding.ToZero);
            if (liras > 0)
                textLiras = ConvertToWords((long)liras) + " Lira";

            var penny = (val - liras) * 100;
            if (penny > 0)
                textPenny = (textLiras == "" ? "" : " ve ") + ConvertToWords((long)penny) + " Kuruş";

            return textLiras + textPenny;
        }
    }
}

