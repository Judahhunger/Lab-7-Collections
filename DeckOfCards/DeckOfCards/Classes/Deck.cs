using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeckOfCards.Classes
{
    public class Deck<T> : IEnumerable<T>
    {
        T[] CardDeck = new T[12];

        int count;

        /// <summary>
        /// Gets length of array
        /// </summary>
        public int Length
        {
            get{ return CardDeck.Length; } 
        }

        /// <summary>
        /// Makes it index so you can interate through with for loop.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get { return CardDeck[index]; }
            set { CardDeck[index] = value; }
        }


        /// <summary>
        /// Takes in deck of cards list and interates through to get comparisons.
        /// counldn't get the typeof or GetType methods to work so made and indexer to do the job.
        /// </summary>
        /// <param name="deck"></param>
        /// <param name="cardToRemove"></param>
       public void Remove(Deck<Cards> deck, Cards cardToRemove)
        {
            int findIndex = -1;
            for (int i = 0; i < deck.Length; i++)
            {
                if (deck[i] != null)
                {
                    if (deck[i].Suites == cardToRemove.Suites && deck[i].Value == cardToRemove.Value)
                    {
                        findIndex = i;
                       typeof(Cards).GetEnumName;
                    }
                }
                
            }
            RemoveAt(findIndex);
        }

        /// <summary>
        /// Starts at the index of item and reassigns items to shift.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < count))
            {
                for (int i = index; i < count - 1; i++)
                {
                    CardDeck[i] = CardDeck[i + 1];
                }
                count--;
            }
           
                Array.Resize(ref CardDeck, CardDeck.Length - 1);
            
        }


        /// <summary>
        /// Adds card to deck if array/deck is full will resize the array to fit more cards.
        /// </summary>
        /// <param name="card"></param>
        public void Add(T card)
        {
            if (count == CardDeck.Length)
            {
                Array.Resize(ref CardDeck, CardDeck.Length * 2);
            }
           
            CardDeck[count++] = card;
        }

        /// <summary>
        /// Fisher-Yates shuffle.
        /// Takes a random number and length of array.
        /// r makes a number inside array 
        /// t is assigned that value of the index at r
        /// index of r is then assigned to index at i
        /// index of i then gets assigned to t the value of what was at r.
        /// </summary>
        public void Shuffle()
        {
            Random randomIndex = new Random();
            int n = count;

            for (int i = 0; i < n; i++)
            {
                int r = randomIndex.Next(n - 1);
                T t = CardDeck[r];
                CardDeck[r] = CardDeck[i];
                CardDeck[i] = t;
            }
               
        }
        
        /// <summary>
        /// Magic Don't touch makes the enumerator for a enumerable thing.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return CardDeck[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

       
    }
}
