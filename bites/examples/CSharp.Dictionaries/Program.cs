namespace CSharp.Dictionaries;

class Program
{
    static void Main(string[] args)
    {
    // create the empty Dictionary
    Dictionary<string, int> menu = new Dictionary<string, int>();

    // add a key-value pair
    menu.Add("huel", 2);

    // add another key-value pair
    menu.Add("coffee", 1);

    // change the price of coffee
    menu["coffee"] = 2;

    // read the price of huel
    int price = menu["huel"];
    // now print it
    Console.WriteLine(price);
    // => 2

    // remove huel from the menu
    menu.Remove("huel");

    menu.Add("Mocha", 4);
    // menu.Add("Mocha", 2);
    int priceMocha = menu["Mocha"];
    Console.WriteLine(priceMocha);

    //check if a key exist in dictionary
    if(menu.ContainsKey("Chips"))
    {
        Console.WriteLine(menu["Chips"]);
    } else {
        System.Console.WriteLine("No such key");
    }

    // Exercise 1
    Dictionary <string, int> scores = new Dictionary<string, int>();

    scores.Add("Green", 5);
    int greenScore = scores["Green"];
    System.Console.WriteLine(greenScore);

    scores["Green"] = 6;
    System.Console.WriteLine(greenScore);

    //Exercise 2

    Dictionary <string, List<int>> scoreList = new Dictionary<string, List<int>>();
    //Add to dict with the value as a list of ints
    scoreList.Add("Blue", new List<int>() {4,6,7,8});
    var blueScores = scoreList["Blue"];

    foreach(int score in blueScores)
        {
            Console.WriteLine(score);
        }
    // Practice using the key to change a team's scores

    blueScores[0] = 5;

        foreach(int score in blueScores)
        {
            Console.WriteLine(score);
        }

    //Exercise 3

    RockPaperScissors myPlay = new RockPaperScissors();
    string roundOne = myPlay.Rules["Rock"]["Paper"];
    Console.WriteLine(roundOne);
    string roundTwo = myPlay.Rules["Scissors"]["Paper"];
    Console.WriteLine(roundTwo);
    string roundThree = myPlay.Rules["Paper"]["Paper"];
    Console.WriteLine(roundThree);
    }
}
