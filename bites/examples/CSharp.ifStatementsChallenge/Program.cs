namespace CSharp.ifStatementsChallenge;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(LeapYear.IsLeapYear(2000));
        Console.WriteLine(LeapYear.IsLeapYear(1970));
        Console.WriteLine(LeapYear.IsLeapYear(1900));
        Console.WriteLine(LeapYear.IsLeapYear(1988));
        Console.WriteLine(LeapYear.IsLeapYear(1500));

        LeapYear.LeapYearsBetween(1950, 2001);
        Console.WriteLine($"Next Leap year: {LeapYear.ClosestLeapYear(1949)}");
    }
}
