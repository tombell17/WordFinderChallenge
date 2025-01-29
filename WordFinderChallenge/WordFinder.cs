public class WordFinder
{
    private readonly List<string> rowsAndColumns;
    public WordFinder(IEnumerable<string> matrix)
    {
        rowsAndColumns = [.. matrix, .. WordFinderHelper.GetColumns(matrix)];
    }

    public IEnumerable<string> Find(IEnumerable<string> wordstream)
    {
        var wordCounts = new Dictionary<string, int>();
        
        foreach(var wordToFind in wordstream)
        {
            // Skip if we already found the word and it is repeated on the wordstream list.
            if(wordCounts.ContainsKey(wordToFind))
                continue;
            
            var occurrences = 0;
            foreach(var rowColumn in rowsAndColumns)
            {
                occurrences += WordFinderHelper.CountWordOccurrences(rowColumn, wordToFind);
            }

            // Add the word to the dictionary if it was found at least once.
            if(occurrences > 0)
                wordCounts.Add(wordToFind, occurrences);
        }

        return WordFinderHelper.GetTopTenWords(wordCounts);
    }
}

    
