using System;
using System.Collections.Generic;
using System.Text;

namespace UnicodeTools.Interfaces
{
    public interface IUnicodeLanguageParser
    {
        string CreateUnicodeCharactersString(string text);
        List<char> CreateUnicodeCharactersList(string text);
        char GetUnicodeCharacter(char character);
    }
}
