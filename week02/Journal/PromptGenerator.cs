using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What conversation today mede me think the most?",
        "Where did I notice something beautiful or meaningful today?",
        "what challenge tested me the most today, and how did I handle it?",
        "What surprise me the most about today?",
        "If I could give myself one piece of advice about today, what would it to be?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
