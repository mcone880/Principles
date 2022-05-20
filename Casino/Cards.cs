using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class Cards
    {
        public enum eSuit
        {
            Clubs = 1,
            Diamonds = 2,
            Hearts = 3,
            Spades = 4
        }

        public enum eCardNumber
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13
        }

        public bool isHeld = false;

        public eSuit Suit { get; set; }
        public eCardNumber CardNumber { get; set; }

        public Cards() { }
        public Cards(eCardNumber cardNumber, eSuit name)
        {
            this.Suit = name;
            this.CardNumber = cardNumber;
        }
    }
}
