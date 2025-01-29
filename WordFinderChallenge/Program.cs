var input = new List<string>
{
    "abcdcold",
    "fgwioash",
    "chillasi",
    "pqnsdasl",
    "uvdxyasl"
};

var wordsToFind = new List<string>
{
    "cold",
    "wind",
    "snow",
    "chill",
    "chill",
    "chill",
    "wind",
};


var wordFinder = new WordFinder(input);
var results = wordFinder.Find(wordsToFind);

Console.WriteLine("[RESULT] These are the top 10 most repeated words in the array:");
foreach(var result in results)
{
    Console.WriteLine(result);
}

Console.WriteLine("Done!");