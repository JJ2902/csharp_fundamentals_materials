using System;
using System.Collections.Generic;

namespace CSharp.Sandbox{
    class Queue{
        List<string> people;
    
    public Queue(List<string> people)
    {
        this.people = people;
    }

    internal void Add(string person)
    {
        people.Add(person);
    }

    // Next - which gets and removes the first person in the people List
    internal void Next()
    {
        var nextPerson = people[0];
        people.Remove(nextPerson);
    }

//     internal string Next()
// {
//     if (people.Count > 0)
//     {
//         string firstPerson = people[0];
//         people.RemoveAt(0);
//         return firstPerson;
//     }
//     else
// {
//         return "The queue is empty.";
//     }
// }


    //State - which prints a list of all the people who are currently queuing
    internal string State()
    {
        foreach(string person in people)
        {
            Console.WriteLine(person);
        }
        return "";
    }
}
}