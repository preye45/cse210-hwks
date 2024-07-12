public class Reflection : Activity
{
    private string _activityName = "Reflection";
    private string _introMsg = "Take a few moments to reflect on your experiences and insights. This activity will guide you through thoughtful questions to help you gain perspective and cultivate gratitude.";
    private List<string> _UsedPrompts  = new ();
    private List<string> _UsedFollowUpPrompt = new ();
    private string _questionFileName = "questionPrompts.txt";
    private string _followUpFileName = "followUpPrompts.txt";

    public Reflection () : base()
    {
    }

    private string GetActivityName()
    {
        return _activityName;
    }
    private void ReflectionPrompt()
    {   
        WelcomeMsg(_activityName, _introMsg);
        Console.WriteLine($"Consider the following prompt:\n\n---- {GetPrompt(_UsedPrompts, _questionFileName)} ----");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();
    }

    private void PonderPrompts()
    {
        Console.Write($"> {GetPrompt(_UsedFollowUpPrompt, _followUpFileName)} ");
        GetAnimation(5);
        Console.Write($"> {GetPrompt(_UsedFollowUpPrompt, _followUpFileName)} ");
        GetAnimation(5);
        CompletionMsg(GetSessionTime(), _activityName);
    }

    public void Run()
    {
        ReflectionPrompt();
        PonderPrompts();
    }
}
