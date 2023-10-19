/* Funções úteis para reutilização */
/* Autoria: Charles Serafim Morais */

public class MyFunctions
{

    /* LEITURA DE NÚMEROS */

    static double ReadNumber() // sem try-catch
    {
        double number;

        while (true)
        {
            if (number = double.TryParse(Console.ReadLine())) break; // sai do loop se a leitura for feita com sucesso

            Console.WriteLine("Entrada inválida. Por favor, digite um número.");
            Console.WriteLine();
        }

        return number;
    }

    static double ReadNumber() // com try-catch
    {
        double number;

        while (true)
        {
            try
            {
                number = double.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                Console.WriteLine();
            }
        }

        return number;

    }

    static double ReadWithIndex(string objectDescription, int i)
    {
        double number;

        while (true)
        {
            Console.WriteLine($"{objectDescription} {i}: ");

            number = ReadNumber();
        }

        return score;
    }

    static double ReadWithRange(int min, int max)
    {
        double number;

        while (true)
        {
            number = ReadNumber();

            if (number >= min && number <= max) break;

            Console.WriteLine($"A entrada deve ser algum número entre {min} e {max}. Digite novamente.\n");
        }

        return number;
    }


    /* UTILIDADES */

using System.Text.RegularExpressions;
static bool ReadYesOrNo(string question)
{
    Console.WriteLine($"{question}? (s/n)");
    while (true)
    {
        string option = Console.ReadLine()?.ToLower();

        if (Regex.IsMatch(option, "^(s(im)?|n(ao|ão)|n(ao)?o?)$")) return option.StartsWith("s");

        Console.WriteLine("Entrada inválida.");
        Console.WriteLine($"{question}? (s/n)");
        Console.WriteLine();

    }
}

static void GoOn()
{
    Console.WriteLine();
    Console.WriteLine("Aperte qualquer tecla para continuar...");
    Console.ReadLine();
    Console.Clear();
}

static void PrintList(List<Type> objectList, string listDescription, string typeDescription)
{
    int count = 1;
    Console.WriteLine($"{listDescription}:");
    Console.WriteLine();

    foreach (Type objectInstance in objectList)
    {
        Console.WriteLine($"{count:D3} - {typeDescription}: {objectInstance}");
        count++;
    }

    Console.WriteLine();
}


    /* STRINGS */

    using System.Text.RegularExpressions;
    static string ReadWithPattern(string pattern)
{
    string entry;

    while (true)
    {
        entry = Console.ReadLine();

        if (Regex.IsMatch(entry, pattern)) break;

        Console.WriteLine("Entrada inválida. Digite novamente.\n");
    }

    return entry;
}

static string FormatString(string entry)
{
    entry = RemoveAccents(entry);
    entry = RemoveSpecialCharacters(entry);
    entry = RemoveSpaces(entry);
    entry = entry.ToLower();

    return entry;
}

static string RemoveAccents(string entry)
{
    string result = new string(
        entry
            .Normalize(NormalizationForm.FormD)
            .Where(ch => CharUnicodeInfo.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
            .ToArray()
    );
    return result;
}

static string RemoveSpecialCharacters(string entry)
{
    string pattern = @"[^\w\s]";
    string result = Regex.Replace(entry, pattern, string.Empty);
    return result;
}

static string RemoveSpaces(string entry)
{
    string result = entry.Replace(" ", "");
    return result;
}


/* INICIALIZAÇÃO ALEATÓRIA */

static void InitializeIntArray(int[] array, int limit)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(limit);
}

static void InitializeDoubleArray(double[] array, double limit)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.NextDouble() * limit;
}

    
}