using System;
using System.Collections.Generic;
using Xunit;

public class WordFinderTests
{
    [Fact]
    public void Constructor_ValidMatrix_InitializesRowsAndColumns()
    {
        // Arrange
        var matrix = new List<string>
        {
            "abcd",
            "efgh",
            "ijkl",
            "mnop"
        };

        // Act
        var wordFinder = new WordFinder(matrix);

        // Assert
        Assert.NotNull(wordFinder);
    }

    [Fact]
    public void Find_ReturnsTopTenWords()
    {
        // Arrange
        var matrix = new List<string>
        {
            "abcd",
            "efgh",
            "ijkl",
            "mnop"
        };
        var words = new List<string> { "abc", "efg", "ijk", "mno", "aeim", "bfjn", "cgko", "dhlp" };
        var wordFinder = new WordFinder(matrix);

        // Act
        var result = wordFinder.Find(words);

        // Assert
        var expected = new List<string>
        {
            "ABC - Repeated 1 times.",
            "EFG - Repeated 1 times.",
            "IJK - Repeated 1 times.",
            "MNO - Repeated 1 times.",
            "AEIM - Repeated 1 times.",
            "BFJN - Repeated 1 times.",
            "CGKO - Repeated 1 times.",
            "DHLP - Repeated 1 times."
        };
        Assert.Equal(expected, result);
    }

}