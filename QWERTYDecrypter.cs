using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColemakConverter
{
    class QWERTYDecrypter
    {
        private static Dictionary<char, char> conversionTable = new Dictionary<char, char>()
        {
            { 'e', 'f' },
            { 'r', 'p' },
            { 't', 'g' },
            { 'y', 'j' },
            { 'u', 'l' },
            { 'i', 'u' },
            { 'o', 'y' },
            { 'p', ';' },
            { 's', 'r' },
            { 'd', 's' },
            { 'f', 't' },
            { 'g', 'd' },
            { 'j', 'n' },
            { 'k', 'e' },
            { 'l', 'i' },
            { ';', 'o' },
            { 'n', 'k' }
        };

        public static char QWERTYCharToColemak(char original)
        {
            var isEncodedCharacter = conversionTable.ContainsKey(Char.ToLower(original));
            if (isEncodedCharacter)
            {
                var converted = conversionTable[Char.ToLower(original)];
                if (Char.IsUpper(original))
                {
                    return Char.ToUpper(converted);
                }

                return converted;
            }

            return original;
        }

        public static string QWERTYStringToColemak(string original)
        {
            var converted = original.Select(character => QWERTYCharToColemak(character));
            return String.Concat(converted);
        }
    }
}
