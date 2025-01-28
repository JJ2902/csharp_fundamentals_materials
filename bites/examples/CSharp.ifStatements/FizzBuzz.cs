using System;

namespace CSharp.ifStatements{
    class FizzBuzz{
        int num;

        public FizzBuzz(int num)
        {
            this.num = num;
        }

        internal static string Play(int num){
        if(num % 3 == 0 && num % 5 == 0) {
            return "FizzBuzz";
        } else if(num % 3 == 0) {
            return "Fizz";
        } else if(num % 5 == 0) {
            return "Buzz";
        } else {
            return num.ToString();
        }
        }
    }
}