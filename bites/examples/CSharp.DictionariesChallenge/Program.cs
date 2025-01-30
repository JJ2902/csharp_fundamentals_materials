namespace CSharp.DictionariesChallenge;

class Program
{
    static void Main(string[] args)
    {
        ScrabbleScore myWord = new ScrabbleScore();
        var wordOne = myWord.Calculate("EXQUISITELY");
        Console.WriteLine(wordOne);
    }
}
