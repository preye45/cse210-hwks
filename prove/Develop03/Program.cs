using System;

class Program
{
    static void Main(string[] args)
    {
         
        
        Console.WriteLine(" The Scripture Memorizer");
        Console.WriteLine("Welcome to the Scripture Memorizer App.   \n");

        
        DisplayReference theReference = new(book:"", chap:0, vrs_s:0); 
        
        Console.Write("Enter the Scripture in the format - (Book, Chapter, Verse(s) separated by ',') : ");
        string[] listRef = Console.ReadLine().Split(",");
        
       
        if (listRef.Count() == 4)
        {
            
            theReference = new DisplayReference(book:listRef[0], chap:int.Parse(listRef[1]), vrs_s:int.Parse(listRef[2]), vrs_e:int.Parse(listRef[3]));
        }
        if (listRef.Count() == 3)
        {
            theReference = new DisplayReference(book:listRef[0], chap:int.Parse(listRef[1]), vrs_s:int.Parse(listRef[2]));
        }
        
        Console.WriteLine("Enter the scripture verse:\n ");
        theReference.SetVerse();
        
        Scripture scripture = new(theReference);
        
        string isQuit = "";
        while (isQuit != "quit")
        {
            if(scripture.IsAllWordHidden())
            {
                break;
            }

            scripture.HideWord(5);
            Console.Clear();
            scripture.DisplayText();

            Console.Write("Press Enter to continue 👉 and 'QUIT' to stop ❌ the program: ");
            isQuit = Console.ReadLine().ToLower();
        }
    }
}
