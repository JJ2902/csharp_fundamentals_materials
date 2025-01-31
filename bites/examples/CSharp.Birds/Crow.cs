class Crow: IBirdBehaviours
{
    private string Name;

    public Crow(string Name)
    {
        this.Name = Name;
    }

    public string Fly()
    {
        return $"{Name} flies.";
    }
    public string Sing()
    {
        return $"{Name} koos.";
    }
    public string Eat()
    {
        return $"{Name} feasts on fruits.";
    }
}