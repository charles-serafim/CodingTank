/*
DESAFIO 10:

Palavras palíndromos são aquelas que são lidas da direita para a esquerda da mesma
maneira que da esquerda para a direita. Exemplo ARARA. Dado uma palavra, informar se ela
é palíndroma ou não.
*/

using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Desafio10
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry;
            bool read = true;
            bool isPalindrome;

            while(read)
            {
                Console.Clear();

                Console.WriteLine("Digite uma palavra (ou frase):");
                entry = Console.ReadLine();

                entry = FormatString(entry);

                isPalindrome = IsPalindrome(entry);

                Console.WriteLine();
                Console.WriteLine($"{(isPalindrome ? "É": "Não é")} um palíndromo!!!");

                Console.WriteLine();
                Console.WriteLine("Verificar outra palavra (ou frase)? (s/n)");

                read = ReadYesOrNo("Verificar outra palavra (ou frase)? (s/n)");
            }

            Console.Clear();
        }

        static bool IsPalindrome(string entry)
        {
            for(int i = 0; i < (entry.Length) / 2; i++)
                if(entry[i] != entry[entry.Length - 1 - i]) return false;

            return true;
        }

        static bool ReadYesOrNo(string message)
        {
            while(true)
            {
                string option = Console.ReadLine()?.ToLower();

                if(Regex.IsMatch(option, "^(s(im)?|n(ao|ão)|n(ao)?o?)$")) return option.StartsWith("s");

                Console.WriteLine($"Entrada inválida. {message} (s/n)");
                Console.WriteLine();
            }
        }

        static string FormatString(string entry)
        {
            entry = RemoveAccents(entry);
            entry = RemoveSpecialCharacters(entry);
            entry = RemoveSpaces(entry);
            entry = entry.ToLower();

            return entry;
        }

        static string RemoveAccents(string text)
        {
            string result = new string(
                text
                    .Normalize(NormalizationForm.FormD)
                    .Where(ch => CharUnicodeInfo.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                    .ToArray()
            );
            return result;
        }

        static string RemoveSpecialCharacters(string text)
        {
            string pattern = @"[^\w\s]";
            string result = Regex.Replace(text, pattern, string.Empty);
            return result;
        }

        static string RemoveSpaces(string text)
        {
            string result = text.Replace(" ", "");
            return result;
        }

    }
}