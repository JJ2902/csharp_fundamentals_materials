namespace CSharp.InstanceField;

class Program
    {
        static void Main(string[] args)
        {
            Quiz myQuiz = new Quiz("What is the capital of France?", "How many colors are there in a rainbow?");

            // Now you can use myQuiz object to access questionOne and questionTwo
            Console.WriteLine(myQuiz.QuestionOne);
            Console.WriteLine(myQuiz.QuestionTwo);


            ProgLang myProgLang = new ProgLang("C Sharp", 2000, "Anders Hejlsberg");

            System.Console.WriteLine(myProgLang.Name);
            System.Console.WriteLine(myProgLang.YearOfCreation);
            System.Console.WriteLine(myProgLang.Creator);

            Bagel myBagel = new Bagel("sesame","salted beef & mustard", 5);

            Console.WriteLine($"A {myBagel.Seeds} seeded bagel with {myBagel.Filling} filling, cost ${myBagel.Price}. How pricey!");
        }
    }

// class Quiz{
//     string questionOne;
//     string questionTwo;

//     public Quiz(string questionOne, string questionTwo)
//     {
//         this.questionOne = questionOne;
//         this.questionTwo = questionTwo;
//     }
// }
