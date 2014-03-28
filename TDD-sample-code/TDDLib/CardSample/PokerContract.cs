using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDLib.CardSample
{
    public enum SuitEnum { Heart = 1, Diamond, Spade, Club };
    public enum ValueEnum { One = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace };

    public class Card
    {
        public Card(SuitEnum suit, ValueEnum val)
        {
            this.Suit = suit;
            this.Value = val;
        }

        public SuitEnum Suit { get; set; }
        public ValueEnum Value { get; set; }

        public static bool IsSameValue(Card a, Card b)
        {
            return a.Value == b.Value;
        }

        public static bool IsSameSuit(Card a, Card b)
        {
            return a.Suit == b.Suit;
        }

        //public static bool IsSameCard(Card a, Card b)
        //{
        //    return false;
        //}
    }

    public class PokerHand
    {
        public PokerHand()
        {
            Cards = new List<Card>();
        }

        public List<Card> Cards { get; set; }
    }

    public interface IPokerRules
    {
        bool IsOnePair(PokerHand hand);
        bool IsTwoPair(PokerHand hand);
        bool IsThreeOfAKind(PokerHand hand);

        // Straight, Flush, Fullhouse, FourOfAKind, StraightFlush
    }

    public class GameException : Exception
    {
    }
}
