using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumLibrary
{
    public static class CardUtilities
    {
        public static string ToName(string abbreviation)
        {
            int CardVal = Int32.Parse(abbreviation.Substring(0, 1));
            string CardSuit = abbreviation.Substring(1, 1);

            List<string> SuitsList = new List<string> { "Spades", "Clubs", "Diamonds", "Hearts" };

            string CardValName = Enum.GetName(typeof(CardVals), CardVal);
            string CardSuitName = "";

            foreach (string suitStr in SuitsList)
            {
                if (CardSuit == suitStr.Substring(0, 1))
                {
                    CardSuitName = suitStr;
                    break;
                }
            }

            if (CardSuitName != "")
            {
                return CardValName + " of " + CardSuitName;
            } else
            {
                return "The card you have provided does not exist";
            }
            
        }

        public static List<Card> GenerateDeck()
        {
            List<Card> deck = new List<Card>();

            foreach (CardVals val in Enum.GetValues(typeof(CardVals)))
            {
                foreach (Suits suit in Enum.GetValues(typeof(Suits)))
                {
                    deck.Add(new Card(val, suit));
                }
            }

            return deck;
        }

        public static List<Card> ShuffleDeck(List<Card> CardsDeck)
        {
            Random rand = new Random();
            List<Card> shuffledDeck = new List<Card>();

            for (int i = 0; i <= CardsDeck.Count-1; ++i)
            {
                int randIndex = rand.Next(0, i);

                shuffledDeck.Insert(randIndex, CardsDeck[i]);
            }

            return shuffledDeck;
        }

        public static List<Card> DealHand(List<Card> ShuffledDeck, int n)
        {
            List<Card> hand = ShuffledDeck;

            hand.RemoveRange(0, 52 - n); // As the deck is already shuffled, we don't need to worry about the randomness

            return hand;
        }
    }
}
