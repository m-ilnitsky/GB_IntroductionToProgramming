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

string[] GetWordsRecursivelyInner(char[] alphabet, string[] inputWords, int lettersCountForAdd)
{
    if (lettersCountForAdd == 0)
    {
        return inputWords;
    }

    var outputWordsCount = inputWords.Length * alphabet.Length;
    var outputWords = new string[outputWordsCount];

    for (int i = 0; i < inputWords.Length; i++)
    {
        for (int j = 0; j < alphabet.Length; j++)
        {
            var outputWordIndex = i * alphabet.Length + j;
            outputWords[outputWordIndex] = $"{inputWords[i]}{alphabet[j]}";
        }
    }

    return GetWordsRecursivelyInner(alphabet, outputWords, lettersCountForAdd - 1);
}

string[] GetWordsRecursively(char[] alphabet, int wordLettersCount)
{
    if (wordLettersCount < 1)
    {
        return new string[0];
    }

    var words = new string[alphabet.Length];

    for (int i = 0; i < alphabet.Length; i++)
    {
        words[i] = alphabet[i].ToString();
    }

    return GetWordsRecursivelyInner(alphabet, words, wordLettersCount - 1);
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
        var words1 = GetWords(alphabet, i);
        var words2 = GetWordsRecursively(alphabet, i);

        Console.WriteLine();

        Console.Write($"Из {i} букв ИТЕРАТИВНО получилось {words1.Length} слов: ");
        WriteStrings(words1);

        Console.Write($"Из {i} букв РЕКУРСИВНО получилось {words2.Length} слов: ");
        WriteStrings(words2);
    }
}

Console.WriteLine();