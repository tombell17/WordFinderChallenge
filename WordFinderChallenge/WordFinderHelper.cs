public static class WordFinderHelper
{
    public static IEnumerable<string> GetTopTenWords(Dictionary<string, int> wordCounts)
    {
        return wordCounts.OrderByDescending(kvp => kvp.Value)
                            .Take(10)
                            .Select(kvp => $"{kvp.Key.ToUpper()} - Repeated {kvp.Value} times.");
    }

    public static List<string> GetColumns(IEnumerable<string> rows)
    {
        List<string> result = [];

        int rowCount = rows.Count();
        int colCount = rows.First().Length;
        for (int j = 0; j < colCount; j++)
        {
            char[] colChars = new char[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                colChars[i] = rows.ElementAt(i)[j];
            }
            result.Add(new string(colChars)); // Convert char array to string
        }

        return result;
    }

    public static int CountWordOccurrences(string text, string word)
    {
        int occurrences = 0;
        int index = 0;

        while((index = text.IndexOf(word, index)) != -1)
        {
            occurrences++;
            index += word.Length;
        }   

        return occurrences;
    }
}

    
