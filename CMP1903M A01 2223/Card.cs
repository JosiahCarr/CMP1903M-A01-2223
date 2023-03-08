using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public Card()
        {

            string[] Values = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
            string[] Suits = {"Clubs", "Hearts", "Diamonds", "Spades"};
            //Console.WriteLine(Values[Value] + " of " + Suits[Suit]);
        }

        public int Value { get; set; }
        /**
        {
            get { return this.Value; }
            set { this.Value = value; }
        }
        **/
        public int Suit { get; set; }
    }
}
