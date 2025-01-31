class Penguin: IBirdBehaviours
{
    private string Name;

    public Penguin(string Name)
    {
        this.Name = Name;
    }

    public string Fly()
    {
        return $"{Name} cannot fly.";
    }
    public string Sing()
    {
        return $"{Name} starts a duet.";
    }
    public string Eat()
    {
        return $"{Name} feasts on donuts.";
    }
}