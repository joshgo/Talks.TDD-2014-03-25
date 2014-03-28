using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TDDLib.CardSample;

namespace TDD.NUnitTest
{
    [TestFixture]
    public class Sample3_Poker_Test
    {
        [Test]
        public void IsOnePair()
        {
            // Get an instance of a PokerGame
            IPokerRules game =  new FunLinqPoker();
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

        //[Test]
        //[ExpectedException(typeof(GameException))]
        //public void IsOnePairNullValidationExpectGameException()
        //{
        //    IPokerRules game = new FunPoker();
        //    game.IsOnePair(null);
        //}

        [Test]
        public void IsOnePairFail()
        {
            // Get an instance of a PokerGame
            IPokerRules game = new FunLinqPoker();
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

        [Test]
        [ExpectedException(typeof(GameException))]
        public void IsOnePairValidHand_NoRepeats()
        {
            throw new NotImplementedException();
        }

        // Poor man's factory/injector
        public IPokerRules GetPokerGame()
        {
            return Activator.CreateInstance("TDDLib", "TDDLib.CardSample.FunPoker")
                .Unwrap() as IPokerRules;
        }

    }
}
