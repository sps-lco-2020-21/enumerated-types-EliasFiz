using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumLibrary;

namespace EnumConsole
{
    class Program
    {   
        static void Main(string[] args)
        {

            // Will generate a deck of cards and write to console every card in the deck
            List<Card> deck = CardUtilities.GenerateDeck();
            List<Card> shuffledDeck = CardUtilities.ShuffleDeck(deck);
            List<Card> hand = CardUtilities.DealHand(shuffledDeck, 5);
            foreach (Card card in hand)
            {
                Console.Write(card.value);
                Console.WriteLine(card.suit);
            }
            Console.WriteLine(hand.Count);

            Console.WriteLine(CardUtilities.ToName("5D"));
            Console.ReadKey();
        }
    }
}
