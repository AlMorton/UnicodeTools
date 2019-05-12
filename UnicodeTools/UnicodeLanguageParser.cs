using System.Collections.Generic;
using System.Text;
using UnicodeTools.Interfaces;

namespace UnicodeTools
{
    public class UnicodeLanguageParser : IUnicodeLanguageParser
    {
        private UnicodeRange _unicodeRange;
        public UnicodeLanguageParser(UnicodeRange unicodeRange)
        {
            _unicodeRange = unicodeRange;
        }

        public string UnicodeCharactersToString(string text)
        {
            var sb = new StringBuilder();
            foreach (char c in text)
            {
                var parsedC = GetUnicodeCharacter(c);
                if (parsedC != '\0')
                {
                    sb.Append(parsedC);
                }
            }

            return sb.ToString();
        }

        public List<char> FindUnicodeCharacters(string text)
        {
            var characters = new List<char>();
            foreach (char c in text)
            {
                var parsedC = GetUnicodeCharacter(c);
                if (parsedC != '\0')
                {
                    characters.Add(parsedC);
                }
            }

            return characters;
        }

        public char GetUnicodeCharacter(char character)
        {
            if (((int)character >= _unicodeRange.Lowest && (int)character <= _unicodeRange.Highest) && char.IsLetter(character))
            {
                return character;
            }

            return '\0';
        }
    }
}
