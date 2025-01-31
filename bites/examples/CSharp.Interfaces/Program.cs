namespace CSharp.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        TenDayDiary myTenDayDiary = new TenDayDiary(new string[]{"Buttercup", "IQ84"});
        
        IGenericDiary myIGenTenDayDiary = new TenDayDiary(new string[]{"Buttercupfsdf", "IQ84666"});

        Console.WriteLine(myTenDayDiary.AddEntry("New Entry."));
        Console.WriteLine(myTenDayDiary.ReadEntry(2));
        Console.WriteLine(myTenDayDiary.RemoveEntry(2));
        Console.WriteLine(myTenDayDiary.ReadEntry(2));
        Console.WriteLine(myIGenTenDayDiary.ReadEntry(0));

        InfiniteDiary myInfiniteDiary = new InfiniteDiary(new List<string>() {"Hades", "Persephone", "Eurydice"});
        IGenericDiary myInfiniteDiary2 = new InfiniteDiary(new List<string>() {"Hades", "Hermes", "Eurydice"});

        Console.WriteLine(myInfiniteDiary.AddEntry("Opheus"));
        Console.WriteLine(myInfiniteDiary.ReadEntry(3));
        Console.WriteLine(myInfiniteDiary.RemoveEntry(3));
        Console.WriteLine(myInfiniteDiary.ReadEntry(3));
        Console.WriteLine(myInfiniteDiary2.ReadEntry(1));

    }
}
