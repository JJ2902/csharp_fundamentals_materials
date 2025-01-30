namespace CSharp.Sandbox;

class Program
{
    static void Main(string[] args)
    {
        ReadingList myUnread = new ReadingList(new string[]{"Butter", "IQ84"});

        //Add new title
        myUnread.Add("Dog Hearted");

        string allTitles = myUnread.DisplayReadingList();

        Console.WriteLine(allTitles);

        //Challenge Queue

        Queue myQueue = new Queue(new List<string>() {"Hades", "Persephone", "Eurydice"});
        myQueue.Add("Orpheus");
        Console.WriteLine("Current Queue:");
        myQueue.State();
        myQueue.Next();
        Console.WriteLine("Current Queue:");
        myQueue.State();

    }
}
