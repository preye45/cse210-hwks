public class Breathing : Activity
{
    private string _activityName = "Breathing"; 
    private string _introMsg = "This guided practice will help you relax and find calmness by focusing on slow and intentional breathing. Let's begin.";

    public Breathing ()
    {
    }
    private void Breath ()
    {
        DateTime date = DateTime.Now;
        WelcomeMsg(_activityName, _introMsg);
        DateTime future = date.AddSeconds(GetSessionTime());
        int breathingLength = 5;
        
        do
        {
            Console.Write("breathe IN ");
            CountDown(breathingLength);
            Console.Write("breathe OUT");
            CountDown(breathingLength);
            Console.WriteLine("");
        } while (DateTime.Now < future);
        CompletionMsg(GetSessionTime(), _activityName);
    }

    public void Run()
    {
        Breath();
    }
}
