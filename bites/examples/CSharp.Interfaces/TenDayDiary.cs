public class TenDayDiary:IGenericDiary
{
    private string[] Entries = new string[10];

    public TenDayDiary(string[] Entries = null)
    {
        if (Entries != null)
        {
            if (Entries.Length > 10)
            {
                throw new ArgumentException("Cannot have more than 10 entries");
            }
            Array.Copy(Entries, this.Entries, Entries.Length);
        }
    }

    public string AddEntry(string NewEntry)
    {
        for (int i = 0; i< Entries.Length; i++)
        {
            if (Entries[i] == null)
            {
                Entries[i] = NewEntry;
                return "Entry added.";
            }
        }

        return "You already have 10 entries.";
    }
    public string RemoveEntry(int EntryIndex)
    {
        if (EntryIndex >= 0 && EntryIndex < Entries.Length)
        {
            if(Entries[EntryIndex] != null)
            {
                Entries[EntryIndex] = null;
                return "Entry removed.";
            }
        } 
        return "No entry at given index.";
    }
    public string ReadEntry(int EntryIndex)
    {
        if(Entries[EntryIndex] != null)
            {
                return Entries[EntryIndex].ToString();
            }
        return "No entry at given index.";
    } 
}

