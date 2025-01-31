namespace CSharp.Birds;

class Program
{
    static void Main(string[] args)
    {
        IBirdBehaviours PenguinOne = new Penguin("Pengu");
        IBirdBehaviours CrowOne = new Crow("KooKoo");
        Console.WriteLine(PenguinOne.Sing());
        Console.WriteLine(CrowOne.Sing());
    }
}
