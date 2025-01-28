using System;

namespace CSharp.ifStatementsChallenge{
    class LeapYear{
        int Year;

        public LeapYear(int Year)
        {
        this.Year = Year; 
        }

        //Method with if statement

        internal static bool IsLeapYear(int Year){
            if (Year % 400 == 0){
                return true;
            } else if (Year % 100 == 0 && Year % 400 != 0){
                return false;
            } else if (Year % 4 == 0 && Year % 100 != 0){
                return true;
            } else if (Year % 4 != 0){
                return false;
            }
            return false;
        }
        // Add a method which takes a start year and an end year, and returns an array of all the leap years between.
        // int[] myNum = {10, 20, 30, 40};


        internal static void LeapYearsBetween(int startYear, int endYear){
            var leapYears = new List<int> ();
            for (int i = startYear; i<= endYear; i++){
                if (IsLeapYear(i)== true){
                    leapYears.Add(i);
                    Console.WriteLine(i);
                }
            }
            //return leapYears;
        }

        // Add a method which, when given a year, will return the closest leap year (this could be before or after the given year).

        internal static int ClosestLeapYear(int Year){
            int nextLeapYear = Year;
            while(!IsLeapYear(nextLeapYear)){
                nextLeapYear ++;
            }
            return nextLeapYear;
        }

    }
}