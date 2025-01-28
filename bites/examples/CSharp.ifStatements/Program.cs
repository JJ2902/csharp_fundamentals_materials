namespace CSharp.ifStatements;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(FizzBuzz.Play(1));
        Console.WriteLine(FizzBuzz.Play(3));
        Console.WriteLine(FizzBuzz.Play(5));
        Console.WriteLine(FizzBuzz.Play(15));

        // for loop fizzbuzz
        for(int i = 1; i<= 10; i++){
            Console.WriteLine(FizzBuzz.Play(i));
        }

        // while loop fizz buzz
        int counter = 0;
        while(counter < 10) {
        Console.WriteLine(FizzBuzz.Play(counter));
        counter++;
        }

        //challenge 1 - count down from 10 to 0
        Console.WriteLine("Challenge 1");
        for(int i = 10; i >= 0; i--){
            Console.WriteLine(FizzBuzz.Play(i));
        }
    }
}
