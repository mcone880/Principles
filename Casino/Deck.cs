using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
