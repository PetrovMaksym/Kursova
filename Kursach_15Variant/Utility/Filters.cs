using System;

namespace Kursach_15Variant.Utility
{
    public static class Filters
    {
        public static bool FilterAuthor_Publishing(string input, out string param)
        {
            bool result = false;
            foreach (char item in input)
            {
                if (Char.IsNumber(item))
                    result = true;
                else if (Char.IsPunctuation(item))
                    result = true;
                else if (Char.IsSymbol(item))
                    result = true;
            }
            param = "Author/Publishing";
            return result;
        }

        public static bool FilterTitle(string input, out string param)
        {
            bool result = false;
            foreach (char item in input)
            {
                if (Char.IsPunctuation(item))
                    result = true;
                else if (Char.IsSymbol(item))
                    result = true;
            }
            param = "Title";
            return result;
        }
    }
}
