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
            var occurrences = 0;
            foreach(var rowColumn in rowsAndColumns)
            {
                occurrences += WordFinderHelper.CountWordOccurrences(rowColumn, wordToFind);
            }

            wordCounts.Add(wordToFind, occurrences);
        }

        return WordFinderHelper.GetTopTenWords(wordCounts);
    }
}

    
