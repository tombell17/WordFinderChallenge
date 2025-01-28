using WordFinderChallenge;
using Xunit;

namespace WordFinderChallenge.Tests
{
    public class WordFinderHelperTests
    {
        [Fact]
        public void GetTopTenWords_ReturnsTopTenWords()
        {
            // Arrange
            var wordCounts = new Dictionary<string, int>
            {
                { "apple", 5 },
                { "banana", 3 },
                { "cherry", 7 },
                { "date", 2 },
                { "elderberry", 6 },
                { "fig", 4 },
                { "grape", 8 },
                { "honeydew", 1 },
                { "kiwi", 9 },
                { "lemon", 10 },
                { "mango", 11 }
            };

            // Act
            var result = WordFinderHelper.GetTopTenWords(wordCounts);

            // Assert
            var expected = new List<string>
            {
                "MANGO - Repeated 11 times.",
                "LEMON - Repeated 10 times.",
                "KIWI - Repeated 9 times.",
                "GRAPE - Repeated 8 times.",
                "CHERRY - Repeated 7 times.",
                "ELDERBERRY - Repeated 6 times.",
                "APPLE - Repeated 5 times.",
                "FIG - Repeated 4 times.",
                "BANANA - Repeated 3 times.",
                "DATE - Repeated 2 times."
            };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetColumns_ReturnsColumns()
        {
            // Arrange
            var rows = new List<string>
            {
                "abcd",
                "efgh",
                "ijkl",
                "mnop"
            };

            // Act
            var result = WordFinderHelper.GetColumns(rows);

            // Assert
            var expected = new List<string>
            {
                "aeim",
                "bfjn",
                "cgko",
                "dhlp"
            };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CountWordOccurrences_ReturnsCorrectCount()
        {
            // Arrange
            string text = "banana banana banana";
            string word = "banana";

            // Act
            int result = WordFinderHelper.CountWordOccurrences(text, word);

            // Assert
            Assert.Equal(3, result);
        }
    }
}