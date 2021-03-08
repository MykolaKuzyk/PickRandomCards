using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string start;
            Console.WriteLine("Do you want start test ? Enter 0 - Yes, 2 - NO /n");
            start = Console.ReadLine();

            if (start == "0")
            {
                CardPicker newPick = new CardPicker();
                newPick.MessageController(0);
            }
            else
            {
                
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Goodbay Then");
                
            }
        }
    }
}
