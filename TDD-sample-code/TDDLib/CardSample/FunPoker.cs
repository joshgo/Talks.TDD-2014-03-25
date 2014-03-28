using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDLib.CardSample
{
    public class FunPoker : IPokerRules
    {
        public bool IsOnePair(PokerHand hand)
        {
            Dictionary<ValueEnum, int> counter = new Dictionary<ValueEnum, int>();

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                var value = hand.Cards[i].Value;

                if (!counter.ContainsKey(value))
                    counter[value] = 0;

                counter[value]++;
            }

            return counter.Where(x => x.Value == 2).Count() == 1;
        }

        public bool IsTwoPair(PokerHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(PokerHand hand)
        {
            throw new NotImplementedException();
        }
    }

    public class FunLinqPoker : IPokerRules
    {
        public bool IsOnePair(PokerHand hand)
        {
            return hand.Cards.GroupBy(x => x.Value,
                (y, g) => new { Value = y, Count = g.Count() })
                .Where(z => z.Count == 2)
                .Count() == 1;
        }

        public bool IsTwoPair(PokerHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(PokerHand hand)
        {
            throw new NotImplementedException();
        }
    }
}
