using System;

namespace CSharp.Dictionaries{
    class RockPaperScissors
    {
        public Dictionary<string, Dictionary<string, string>> Rules;

        public RockPaperScissors()
        {
            Rules = new Dictionary<string, Dictionary<string, string>>
            {
                {"Rock", new Dictionary<string, string>
                {
                    ["Rock"] = "It's a draw.", 
                    ["Paper"] = "Player 1 loses.",
                    ["Scissors"] = "Player 2 loses."
                }}, 
                {"Paper", new Dictionary<string, string>
                {
                    ["Rock"] = "Player 2 loses.", 
                    ["Paper"] = "It's a draw.",
                    ["Scissors"] = "Player 1 loses." 
                }},
                {"Scissors", new Dictionary<string, string>
                    {
                    ["Rock"] = "Player 1 loses.", 
                    ["Paper"] = "Player 2 loses.",
                    ["Scissors"] = "It's a draw." 
                    }
                }
            };
        }
    }
}