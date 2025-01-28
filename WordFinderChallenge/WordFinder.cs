public class WordFinder
{
    private readonly List<string> rowsAndColumns;
    public WordFinder(IEnumerable<string> matrix)
    {
        //Add Input Validations
        // if(matrix.isNullOrEmpty())
        // {
        //     throw new ArgumentException("Matrix cannot be null or empty");
        // }
        rowsAndColumns = [.. matrix, .. WordFinderHelper.GetColumns(matrix)];
    }

    public IEnumerable<string> Find(IEnumerable<string> words)
    {
        var wordCounts = new Dictionary<string, int>();
        
        foreach(var wordToFind in words)
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

    
