using System;
using System.Collections.Generic;

class PromptGenerator
{
  public static string GetRandomPrompt()
  {
    List<string> prompts = new List<string>
        {
        "What new skill or knowledge did you acquire today, if any?",
        "Did you encounter any unexpected challenges today, and how did you handle them?",
        "How did I see the hand of the Lord in my life today?",
        "How did you prioritize your tasks or activities today, and did it align with your goals or values?",
        "Did you engage in any acts of kindness or generosity today, and how did it make you feel?"
        };

    Random random = new Random();
    int index = random.Next(prompts.Count);
    return prompts[index];
  }
}