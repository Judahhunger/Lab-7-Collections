using System;
using System.Collections;
using System.Collections.Generic;
using DeckOfCards.Classes;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("base deck __________");
            ShowDeck(makeCards());
            Console.ReadLine();
            Console.WriteLine("------added to deck below-----");
            ShowAdd();
            Console.ReadLine();
            Console.WriteLine("Shows Hearts removed from base deck");
            ShowRemove();
            showShuffle();
            Console.ReadLine();
        }

        /// <summary>
        /// Hard codded cards and made new list then retruned it.
        /// </summary>
        /// <returns>Deck<Cards></returns>
        public static Deck<Cards> makeCards()
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

            Cards card7 = new Cards
            {
                Value = (Value)1,
                Suites = (Suites)102
            };

            Cards card8 = new Cards
            {
                Value = (Value)3,
                Suites = (Suites)102
            };

            Cards card9 = new Cards
            {
                Value = (Value)10,
                Suites = (Suites)102
            };

            Deck<Cards> cardDeck = new Deck<Cards>
            {
                card1,card2,card3,card4,card5,card6,card7,card8,card9
            };

            return cardDeck;
        }

        /// <summary>
        /// Takes in deck of cards and shows those cards
        /// </summary>
        /// <param name="cardDeck"></param>
        public static void ShowDeck(Deck<Cards> deck)
        {
            foreach (var item in deck)
            {
                Console.WriteLine($"{item.Value} of {item.Suites}");
            }

        }

        /// <summary>
        /// Shows that we can add to deck with add method from deck class.
        /// </summary>
        public static void ShowAdd()
        {
            Deck<Cards> deckWithAddCards = makeCards();

            Cards card10 = new Cards
            {
                Value = (Value)1,
                Suites = (Suites)103
            };

            Cards card11 = new Cards
            {
                Value = (Value)3,
                Suites = (Suites)103
            };

            Cards card12 = new Cards
            {
                Value = (Value)10,
                Suites = (Suites)103
            };

            deckWithAddCards.Add(card10);
            deckWithAddCards.Add(card11);
            deckWithAddCards.Add(card12);

            ShowDeck(deckWithAddCards);
        }

        /// <summary>
        /// made to visualize the remove.
        /// </summary>
        public static void ShowRemove()
        {
            Deck<Cards> showRemoveDeck = makeCards();


            Cards card4 = new Cards
            {
                Value = (Value)1,
                Suites = (Suites)101
            };

            Cards card3 = new Cards
            {
                Value = (Value)10,
                Suites = (Suites)100
            };

            showRemoveDeck.Remove(showRemoveDeck, card3);
            showRemoveDeck.Remove(showRemoveDeck, card4);
            ShowDeck(showRemoveDeck);
        }

        /// <summary>
        /// made to show the shuffle.
        /// </summary>
        public static void showShuffle()
        {
            Deck<Cards> myDeck = makeCards();
            Console.WriteLine("_________before shuffle_______");
            ShowDeck(myDeck);
            myDeck.Shuffle();
            Console.WriteLine("-----after shuffle----");
            ShowDeck(myDeck);
        }

    }
}
