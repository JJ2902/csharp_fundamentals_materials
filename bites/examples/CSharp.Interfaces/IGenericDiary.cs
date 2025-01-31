interface  IGenericDiary
{
    internal string AddEntry(string NewEntry);

    internal string RemoveEntry(int EntryIndex);

    internal string ReadEntry(int EntryIndex);
}