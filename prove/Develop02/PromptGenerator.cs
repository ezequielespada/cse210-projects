public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>();
    }

    public string GetRandomPrompt()
    {
        if (_prompts != null && _prompts.Count > 0)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, _prompts.Count);
            return _prompts[randomIndex];
        }
        else
        {
            return "No prompts available";
        }
    }
}