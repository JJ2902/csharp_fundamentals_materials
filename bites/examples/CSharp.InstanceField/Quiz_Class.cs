using System;

namespace CSharp.InstanceField
{
    public class Quiz
    {
        public string QuestionOne { get; private set; }
        public string QuestionTwo { get; private set; }

        public Quiz(string questionOne, string questionTwo)
        {
            this.QuestionOne = questionOne;
            this.QuestionTwo = questionTwo;
        }
    }
}