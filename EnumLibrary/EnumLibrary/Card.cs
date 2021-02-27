using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumLibrary
{
    public class Card
    {
        public CardVals value;
        public Suits suit;

        public Card(CardVals inValue, Suits inSuit)
        {
            value = inValue;
            suit = inSuit;
        }
    }
}
