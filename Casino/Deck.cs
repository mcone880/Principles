using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls; 
using static Casino.Cards;

namespace Casino
{
    class Deck
    {
        public List<Cards> lstCards = new List<Cards>(); 

        public Deck() { }

        // generates cards of a standard 52 card deck
        public void Reset() 
        {
            lstCards = Enumerable.Range(1, 4).SelectMany(s => Enumerable.Range(1, 13).Select(c => new Cards() { Suit = (eSuit)s, CardNumber = (eCardNumber)c })).ToList(); 
        }

        // randomly orders cards using LINQ
        public void Shuffle() 
        {
            lstCards = lstCards.OrderBy(c => Guid.NewGuid()).ToList(); 
        }

        // returns next card in deck and removes said card from collection
        public Cards TakeCard() 
        {
            var card = lstCards.FirstOrDefault();
            lstCards.Remove(card);

            return card; 
        }

        // allows user to take multiple cards from deck and removes those cards from collection
        public IEnumerable<Cards> TakeCards(int numberOfCards) 
        {
            var cards = lstCards.Take(numberOfCards);

            var takeCards = cards as Cards[] ?? cards.ToArray();
            lstCards.RemoveAll(takeCards.Contains);

            return takeCards; 
        }

        // returns string of card image
        public string DisplayCard(Cards card)
        {
            // clubs
            if (card.Suit == eSuit.Clubs && card.CardNumber == eCardNumber.Ace) return "/Assets/Blackjack/Cards/cardClubsA.png";
            else if (card.Suit == eSuit.Clubs && card.CardNumber == eCardNumber.Two) return "/Assets/Blackjack/Cards/cardClubs2.png";
            else if (card.Suit == eSuit.Clubs && card.CardNumber == eCardNumber.Three) return "/Assets/Blackjack/Cards/cardClubs3.png";
            else if (card.Suit == eSuit.Clubs && card.CardNumber == eCardNumber.Four) return "/Assets/Blackjack/Cards/cardClubs4.png";
            else if (card.Suit == eSuit.Clubs && card.CardNumber == eCardNumber.Five) return "/Assets/Blackjack/Cards/cardClubs5.png";
            else if (card.Suit == eSuit.Clubs && card.CardNumber == eCardNumber.Six) return "/Assets/Blackjack/Cards/cardClubs6.png";
            else if (card.Suit == eSuit.Clubs && card.CardNumber == eCardNumber.Seven) return "/Assets/Blackjack/Cards/cardClubs7.png";
            else if (card.Suit == eSuit.Clubs && card.CardNumber == eCardNumber.Eight) return "/Assets/Blackjack/Cards/cardClubs8.png";
            else if (card.Suit == eSuit.Clubs && card.CardNumber == eCardNumber.Nine) return "/Assets/Blackjack/Cards/cardClubs9.png";
            else if (card.Suit == eSuit.Clubs && card.CardNumber == eCardNumber.Ten) return "/Assets/Blackjack/Cards/cardClubs10.png";
            else if (card.Suit == eSuit.Clubs && card.CardNumber == eCardNumber.Jack) return "/Assets/Blackjack/Cards/cardClubsJ.png";
            else if (card.Suit == eSuit.Clubs && card.CardNumber == eCardNumber.Queen) return "/Assets/Blackjack/Cards/cardClubsQ.png";
            else if (card.Suit == eSuit.Clubs && card.CardNumber == eCardNumber.King) return "/Assets/Blackjack/Cards/cardClubsK.png";

            // spades
            else if (card.Suit == eSuit.Spades && card.CardNumber == eCardNumber.Ace) return "/Assets/Blackjack/Cards/cardSpadesA.png";
            else if (card.Suit == eSuit.Spades && card.CardNumber == eCardNumber.Two) return "/Assets/Blackjack/Cards/cardSpades2.png";
            else if (card.Suit == eSuit.Spades && card.CardNumber == eCardNumber.Three) return "/Assets/Blackjack/Cards/cardSpades3.png";
            else if (card.Suit == eSuit.Spades && card.CardNumber == eCardNumber.Four) return "/Assets/Blackjack/Cards/cardSpades4.png";
            else if (card.Suit == eSuit.Spades && card.CardNumber == eCardNumber.Five) return "/Assets/Blackjack/Cards/cardSpades5.png";
            else if (card.Suit == eSuit.Spades && card.CardNumber == eCardNumber.Six) return "/Assets/Blackjack/Cards/cardSpades6.png";
            else if (card.Suit == eSuit.Spades && card.CardNumber == eCardNumber.Seven) return "/Assets/Blackjack/Cards/cardSpades7.png";
            else if (card.Suit == eSuit.Spades && card.CardNumber == eCardNumber.Eight) return "/Assets/Blackjack/Cards/cardSpades8.png";
            else if (card.Suit == eSuit.Spades && card.CardNumber == eCardNumber.Nine) return "/Assets/Blackjack/Cards/cardSpades9.png";
            else if (card.Suit == eSuit.Spades && card.CardNumber == eCardNumber.Ten) return "/Assets/Blackjack/Cards/cardSpades10.png";
            else if (card.Suit == eSuit.Spades && card.CardNumber == eCardNumber.Jack) return "/Assets/Blackjack/Cards/cardSpadesJ.png";
            else if (card.Suit == eSuit.Spades && card.CardNumber == eCardNumber.Queen) return "/Assets/Blackjack/Cards/cardSpadesQ.png";
            else if (card.Suit == eSuit.Spades && card.CardNumber == eCardNumber.King) return "/Assets/Blackjack/Cards/cardSpadesK.png";

            // hearts 
            else if (card.Suit == eSuit.Hearts && card.CardNumber == eCardNumber.Ace) return "/Assets/Blackjack/Cards/cardHeartsA.png";
            else if (card.Suit == eSuit.Hearts && card.CardNumber == eCardNumber.Two) return "/Assets/Blackjack/Cards/cardHearts2.png";
            else if (card.Suit == eSuit.Hearts && card.CardNumber == eCardNumber.Three) return "/Assets/Blackjack/Cards/cardHearts3.png";
            else if (card.Suit == eSuit.Hearts && card.CardNumber == eCardNumber.Four) return "/Assets/Blackjack/Cards/cardHearts4.png";
            else if (card.Suit == eSuit.Hearts && card.CardNumber == eCardNumber.Five) return "/Assets/Blackjack/Cards/cardHearts5.png";
            else if (card.Suit == eSuit.Hearts && card.CardNumber == eCardNumber.Six) return "/Assets/Blackjack/Cards/cardHearts6.png";
            else if (card.Suit == eSuit.Hearts && card.CardNumber == eCardNumber.Seven) return "/Assets/Blackjack/Cards/cardHearts7.png";
            else if (card.Suit == eSuit.Hearts && card.CardNumber == eCardNumber.Eight) return "/Assets/Blackjack/Cards/cardHearts8.png";
            else if (card.Suit == eSuit.Hearts && card.CardNumber == eCardNumber.Nine) return "/Assets/Blackjack/Cards/cardHearts9.png";
            else if (card.Suit == eSuit.Hearts && card.CardNumber == eCardNumber.Ten) return "/Assets/Blackjack/Cards/cardHearts10.png";
            else if (card.Suit == eSuit.Hearts && card.CardNumber == eCardNumber.Jack) return "/Assets/Blackjack/Cards/cardHeartsJ.png";
            else if (card.Suit == eSuit.Hearts && card.CardNumber == eCardNumber.Queen) return "/Assets/Blackjack/Cards/cardHeartsQ.png";
            else if (card.Suit == eSuit.Hearts && card.CardNumber == eCardNumber.King) return "/Assets/Blackjack/Cards/cardHeartsK.png";

            // diamonds
            else if (card.Suit == eSuit.Diamonds && card.CardNumber == eCardNumber.Ace) return "/Assets/Blackjack/Cards/cardDiamondsA.png";
            else if (card.Suit == eSuit.Diamonds && card.CardNumber == eCardNumber.Two) return "/Assets/Blackjack/Cards/cardDiamonds2.png";
            else if (card.Suit == eSuit.Diamonds && card.CardNumber == eCardNumber.Three) return "/Assets/Blackjack/Cards/cardDiamonds3.png";
            else if (card.Suit == eSuit.Diamonds && card.CardNumber == eCardNumber.Four) return "/Assets/Blackjack/Cards/cardDiamonds4.png";
            else if (card.Suit == eSuit.Diamonds && card.CardNumber == eCardNumber.Five) return "/Assets/Blackjack/Cards/cardDiamonds5.png";
            else if (card.Suit == eSuit.Diamonds && card.CardNumber == eCardNumber.Six) return "/Assets/Blackjack/Cards/cardDiamonds6.png";
            else if (card.Suit == eSuit.Diamonds && card.CardNumber == eCardNumber.Seven) return "/Assets/Blackjack/Cards/cardDiamonds7.png";
            else if (card.Suit == eSuit.Diamonds && card.CardNumber == eCardNumber.Eight) return "/Assets/Blackjack/Cards/cardDiamonds8.png";
            else if (card.Suit == eSuit.Diamonds && card.CardNumber == eCardNumber.Nine) return "/Assets/Blackjack/Cards/cardDiamonds9.png";
            else if (card.Suit == eSuit.Diamonds && card.CardNumber == eCardNumber.Ten) return "/Assets/Blackjack/Cards/cardDiamonds10.png";
            else if (card.Suit == eSuit.Diamonds && card.CardNumber == eCardNumber.Jack) return "/Assets/Blackjack/Cards/cardDiamondsJ.png";
            else if (card.Suit == eSuit.Diamonds && card.CardNumber == eCardNumber.Queen) return "/Assets/Blackjack/Cards/cardDiamondsQ.png";
            else if (card.Suit == eSuit.Diamonds && card.CardNumber == eCardNumber.King) return "/Assets/Blackjack/Cards/cardDiamondsK.png";

            else
            {
                Console.WriteLine("Card not found.");
                return "";
            }
        }
    }
}
