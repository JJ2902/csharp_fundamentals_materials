public class InfiniteDiary: IGenericDiary
{
    List<string> Entries;

    public InfiniteDiary(List<string> Entries)
    {
        this.Entries=Entries;
    }

    public string AddEntry(string NewEntry)
    {
        Entries.Add(NewEntry);
        return "Entry added to infinite diary.";
    }
    public string RemoveEntry(int EntryIndex)
    {
        if(Entries[EntryIndex] != null)
        {
            Entries.RemoveAt(EntryIndex);
            return "Entry removed.";
        }
        return "No entry at given index.";
    }
    public string ReadEntry(int EntryIndex)
    {
        if(EntryIndex >=0 && EntryIndex < Entries.Count)
            {
                return Entries[EntryIndex].ToString();
            }else{
                return "No entry at given index.";
            }
    } 
}