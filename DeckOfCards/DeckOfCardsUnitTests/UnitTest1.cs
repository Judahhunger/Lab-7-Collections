using System;
using Xunit;
using DeckOfCards;
using DeckOfCards.Classes;

namespace DeckOfCardsUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddToDeck()
        {
            Cards card1 = new Cards
            {
                Value = (Value)1,
                Suites = (Suites)100
            };

            Cards card2 = new Cards
            {
                Value = (Value)3,
                Suites = (Suites)100
            };

            Cards card3 = new Cards
            {
                Value = (Value)10,
                Suites = (Suites)100
            };

            Cards card4 = new Cards
            {
                Value = (Value)1,
                Suites = (Suites)101
            };

            Cards card5 = new Cards
            {
                Value = (Value)3,
                Suites = (Suites)101
            };

            Cards card6 = new Cards
            {
                Value = (Value)10,
                Suites = (Suites)101
            };

            Deck<Cards> TestDeck = new Deck<Cards>();
            TestDeck.Add(card1);
            string testString = "";
            foreach (var item in TestDeck)
            {
                testString = $"{item.Suites} : {item.Value}";
            }
            Assert.Equal("Hearts : One", testString);
        }

        [Fact]
        public void TestGettersAndSetters()
        {
            Cards card2 = new Cards();
            card2.Value = (Value)3;
            card2.Suites = (Suites)100;
            
            Assert.Equal("Hearts", card2.Suites.ToString());
        }

        [Fact]
        public void TestRemove()
        {
            int testnumb = 0;
            Cards card1 = new Cards
            {
                Value = (Value)1,
                Suites = (Suites)100
            };
            Cards card2 = new Cards
            {
                Value = (Value)3,
                Suites = (Suites)100
            };
            Cards card3 = new Cards
            {
                Value = (Value)10,
                Suites = (Suites)100
            };
            Cards card4 = new Cards
            {
                Value = (Value)1,
                Suites = (Suites)101
            };
            Deck<Cards> TestDeck = new Deck<Cards>{
            card1,card2,card3,card4 };

            TestDeck.Remove(TestDeck, card3);
            foreach (var item in TestDeck)
            {
                testnumb++;
            }

            Assert.Equal(3, testnumb);
        }

        [Fact]
        public void TestRemoveIfNotIn()
        {
            int testnumb = 0;
            Cards card1 = new Cards
            {
                Value = (Value)1,
                Suites = (Suites)100
            };
            Cards card2 = new Cards
            {
                Value = (Value)3,
                Suites = (Suites)100
            };
            Cards card3 = new Cards
            {
                Value = (Value)10,
                Suites = (Suites)100
            };
            Cards card4 = new Cards
            {
                Value = (Value)1,
                Suites = (Suites)101
            };
            Deck<Cards> TestDeck = new Deck<Cards>{
            card1,card2,card3};

            TestDeck.Remove(TestDeck, card4);
            foreach (var item in TestDeck)
            {
                testnumb++;
            }

            Assert.False(TestDeck.Remove(TestDeck, card4));
        }

        [Fact]
        public void TestShuffle()
        {
            
            Cards card1 = new Cards
            {
                Value = (Value)1,
                Suites = (Suites)100
            };
            Cards card2 = new Cards
            {
                Value = (Value)3,
                Suites = (Suites)100
            };
            Cards card3 = new Cards
            {
                Value = (Value)10,
                Suites = (Suites)100
            };
            Cards card4 = new Cards
            {
                Value = (Value)5,
                Suites = (Suites)101
            };
            Deck<Cards> TestDeck = new Deck<Cards>{
            card1,card2,card3,card4};

            string testString1 = TestDeck[0].Value.ToString();
            TestDeck.Shuffle();
            string testString2 = TestDeck[0].Value.ToString();
            Assert.False(testString1 == testString2);
        }
    }
}
