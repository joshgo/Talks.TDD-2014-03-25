using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDTest
{
    using TDDLib.CardSample;

    [TestClass]
    public class PokerHandTest
    {
        [TestMethod]
        public void IsOnePair()
        {
            // Get an instance of a PokerGame
            IPokerRules game = new FunPoker();
            PokerHand hand = new PokerHand();

            // Set the hand
            hand.Cards.Add(new Card(SuitEnum.Heart, ValueEnum.One));
            hand.Cards.Add(new Card(SuitEnum.Spade, ValueEnum.One));
            hand.Cards.Add(new Card(SuitEnum.Club, ValueEnum.Queen));
            hand.Cards.Add(new Card(SuitEnum.Spade, ValueEnum.King));
            hand.Cards.Add(new Card(SuitEnum.Diamond, ValueEnum.Three));

            // Check if it's true
            Assert.IsTrue(game.IsOnePair(hand));
        }

        [TestMethod]
        public void IsOnePairFail()
        {
            // Get an instance of a PokerGame
            IPokerRules game = new FunPoker();
            PokerHand hand = new PokerHand();

            // Set the hand
            hand.Cards.Add(new Card(SuitEnum.Heart, ValueEnum.One));
            hand.Cards.Add(new Card(SuitEnum.Spade, ValueEnum.One));
            hand.Cards.Add(new Card(SuitEnum.Club, ValueEnum.One));
            hand.Cards.Add(new Card(SuitEnum.Spade, ValueEnum.King));
            hand.Cards.Add(new Card(SuitEnum.Diamond, ValueEnum.Three));

            // Check if it's true
            Assert.IsFalse(game.IsOnePair(hand));
        }

        [TestMethod]
        [ExpectedException(typeof(GameException))]
        public void IsOnePairFailOnEmptyHand()
        {
            // Get an instance of a PokerGame
            IPokerRules game = new FunPoker();
            PokerHand hand = null;

            // Set the hand

            // Check if it's true
            Assert.IsFalse(game.IsOnePair(hand));
        }

        public IPokerRules GetPokerGame()
        {
            return Activator.CreateInstance("TDDLib", "TDDLib.PokerSample.FunPoker")
                .Unwrap() as IPokerRules;
        }
    }
}
