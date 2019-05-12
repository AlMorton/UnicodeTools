using System;
using System.Collections.Generic;
using System.Text;

namespace UnicodeTools.Interfaces
{
    public interface IUnicodeLanguageParser
    {
        string UnicodeCharactersToString(string text);
        List<char> FindUnicodeCharacters(string text);
        char GetUnicodeCharacter(char character);
    }
}
