using System.Text;

// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.
// n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, ав, ва, ви, ив, св, вс

void UpdateIndexes(int alphabetLettersCount, int[] lettersIndexes)
{
    var maxIndex = lettersIndexes.Length - 1;

    lettersIndexes[maxIndex]++;

    for (int i = maxIndex; i >= 0; i--)
    {
        if (lettersIndexes[i] == alphabetLettersCount)
        {
            lettersIndexes[i] = 0;

            if (i > 0)
            {
                lettersIndexes[i - 1]++;
            }
        }
    }
}

string[] GetWords(char[] alphabet, int wordLettersCount)
{
    var alphabetLettersCount = alphabet.Length;
    var wordsCount = (int)Math.Pow(alphabet.Length, wordLettersCount);
    var words = new string[wordsCount];
    var lettersIndexes = new int[wordLettersCount];
    var stringBuilder = new StringBuilder();

    for (int i = 0; i < words.Length; i++)
    {
        for (int j = 0; j < wordLettersCount; j++)
        {
            stringBuilder.Append(alphabet[lettersIndexes[j]]);
        }

        words[i] = stringBuilder.ToString();
        stringBuilder.Clear();
        UpdateIndexes(alphabetLettersCount, lettersIndexes);
    }

    return words;
}

void WriteChars(char[] chars)
{
    Console.WriteLine($"[{string.Join(", ", chars)}]");
}

void WriteStrings(string[] strings)
{
    Console.WriteLine($"[{string.Join(", ", strings)}]");
}

char[][] alphabets = new char[3][];
alphabets[0] = new char[] { 'а', 'и', 'с' };
alphabets[1] = new char[] { 'а', 'и', 'с', 'в' };
alphabets[2] = new char[] { 'а', 'и', 'с', 'в', 'ш' };

foreach (var alphabet in alphabets)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.Write($"Алфавит из {alphabet.Length} символов: ");
    WriteChars(alphabet);

    for (int i = 1; i <= 4; i++)
    {
        var words = GetWords(alphabet, i);
        Console.WriteLine();
        Console.Write($"Из {i} букв получилось {words.Length} слов: ");
        WriteStrings(words);
    }
}

Console.WriteLine();