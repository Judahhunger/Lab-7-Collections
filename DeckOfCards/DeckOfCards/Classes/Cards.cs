using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Classes
{
    public class Cards
    {
        /// <summary>
        /// properties for cards as enums
        /// </summary>
        public Suites Suites { get; set; }

        public Value Value { get; set; }

    }

    /// <summary>
    /// make defualt values for suits 100 - 103
    /// </summary>
    public enum Suites
    {
        Hearts = 100,
        Diamonds,
        Spades,
        Clubs
    }

    /// <summary>
    /// Make defualt values for cards in deck starting at 1 - 14
    /// </summary>
    public enum Value
    {
        One = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace,
    }
}
