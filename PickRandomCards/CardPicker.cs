using System;
using System.Collections.Generic;
using System.Text;

namespace PickRandomCards
{
    class CardPicker
    {
        // Gather all methotds in one place 
        public void MessageController(int gameState)
        {
            
            if (gameState == 0)
            {
                Console.WriteLine("You have started the PickCard Game Congrats! \n");
                Console.WriteLine("Enter the number of cards to pick ");

               String outerLine = Console.ReadLine();
                if (int.TryParse(outerLine, out int numberOfCards))
                {
                    PickSomeCards(numberOfCards);
                    Console.WriteLine("All set !"); 
                }
                else
                {
                    Console.WriteLine("You have entered string instead of number! Try again");
                    MessageController(gameState);
                }
            }
            
        }

        static Random random = new Random();
        // Purpose of this method  is to return several cards 
        // that were picked by user
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickCards = new string[numberOfCards];
            for(int i =0; i < numberOfCards; i++)
            {
                pickCards[i] = RandomValue() + " of " + RandomSuit();
            }
            foreach (string i in pickCards)
            {
                Console.WriteLine("*. Value and suit:{0} ", i);
            }
            return pickCards;
        }

        private static string RandomSuit()
        {
            // get random number from 1 to 4 
            int value = random.Next(1, 5);
            if (value == 1) return " Spades";
            if (value == 2) return " Hearts";
            if (value == 3) return " Clubs";
            return " Diamots";
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return " Ace";
            if (value == 11) return " Jack";
            if (value == 12) return " Queen";
            if (value == 13) return " King";
            return value.ToString();
        }
    }
}
