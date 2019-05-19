using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnicodeTools.Interfaces;

namespace UnicodeTools
{
    public class UnicodeLanguageParser : IUnicodeLanguageParser
    {
        private UnicodeRange _unicodeRange;
        private string _textToParse;
        private StringBuilder _stringBuilder;
        public UnicodeLanguageParser(UnicodeRange unicodeRange)
        {
            _unicodeRange = unicodeRange;
        }

        public List<char> CreateUnicodeCharactersList(string text)
        {            
            var parseText = CreateUnicodeCharactersString(text);
            var characters = text.ToList();
            return characters;
        }
        public string CreateUnicodeCharactersString(string text)
        {
            _textToParse = text;
            _stringBuilder = new StringBuilder();
            ParseText();

            return _stringBuilder.ToString();
        }

        private void ParseText()
        {
            foreach (char character in _textToParse)
            {
                var parsedC = GetUnicodeCharacter(character);
                if (parsedC != '\0')
                {
                    _stringBuilder.Append(parsedC);
                }
            }
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
