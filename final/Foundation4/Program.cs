using System;

class Program
{
    static void Main(string[] args)
    {
        using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        string logo = """
                                                                    
                                            KEEP TRACK OF YOUR EXERCISE ACTIVITIES                                      
        """;
        Console.WriteLine(logo);
        Console.WriteLine("");

        List<Activity> activities = new();
        string menu = "\n1. Running |2. Cycling  | 3. Swimming | 4. Get Track Summary | 5. Quit ";
        int response;

        do
        {
            Console.WriteLine(menu);
            Console.Write("\nChoose your prefered option (enter number): ");
            string input = Console.ReadLine();
            Console.WriteLine("");
            if (int.TryParse(input, out response))
            {
                switch (response)
                {
                    case 1:
                        Running running = new();
                        running.StartRunning();
                        activities.Add(running);
                        break;

                    case 2:
                        Cycling cycling = new();
                        cycling.StartCycling();
                        activities.Add(cycling);
                        break;

                    case 3:
                        Swimming swimming = new();
                        swimming.StartSwimming();
                        activities.Add(swimming);
                        break;

                    case 4:
                        foreach (Activity activity in activities)
                        {
                            activity.GetSummary();
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }  
        } while (response < 5);
        
    }
} 
    }
}
