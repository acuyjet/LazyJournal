using Journal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Journal.Models
{
    public class Prompt
    {
        public int PromptId { get; set; }

        public string PromptText { get; set; }

        public static void Prompts()
        {
            List<Prompt> prompts = new List<Prompt>();

            prompts.Add(new Prompt() { PromptId = 1, PromptText = "What scares you?" });
            prompts.Add(new Prompt() { PromptId = 2, PromptText = "Dear Past Me . . ." });
            prompts.Add(new Prompt() { PromptId = 3, PromptText = "Dear Future Me . . ." });
            prompts.Add(new Prompt() { PromptId = 4, PromptText = "What’s the worst thing you’ve ever done?" });
            prompts.Add(new Prompt() { PromptId = 5, PromptText = "What are you looking forward to the most?" });
            prompts.Add(new Prompt() { PromptId = 6, PromptText = "What's something you're good at?" });
            prompts.Add(new Prompt() { PromptId = 7, PromptText = "What keeps you up at night worrying?" });
            prompts.Add(new Prompt() { PromptId = 8, PromptText = "Who is someone you miss?" });
            prompts.Add(new Prompt() { PromptId = 9, PromptText = "What was your most precious childhood possession?" });
            prompts.Add(new Prompt() { PromptId = 10, PromptText = "What are you grateful for?" });
            prompts.Add(new Prompt() { PromptId = 11, PromptText = "What's the story behind your name?" });
            prompts.Add(new Prompt() { PromptId = 12, PromptText = "What's special about your hometown?" });
            prompts.Add(new Prompt() { PromptId = 13, PromptText = "What are you listening to?" });
            prompts.Add(new Prompt() { PromptId = 14, PromptText = "What's a career you wish you had pursued?" });
            prompts.Add(new Prompt() { PromptId = 15, PromptText = "Tell a story about a childhood friend." });
        }
    }
}
