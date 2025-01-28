namespace CSharp.Strings;

class Program
{
    static void Main(string[] args)
    {
        string plot = "Cat Rescue plot:";
        StoryBuilder myStory = new StoryBuilder(plot);

        string StoryPlotLine = myStory.AddPlotline(" Cat is rescued from a tree.");

        Console.WriteLine(myStory.GetPlot());
        Console.WriteLine(StoryPlotLine);
    }
}
