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

        }

        //Use of encapsulation, data is encapsulated using private variables, which are accessed via the setters and getters
        //which also have valitdation checking, further increasing the security of the data
        private int value;
        public int Value 
        {
            get
            {
                return (this.value);
            }
            set
            {
                this.value = value;
                if (this.value > 13 || this.value < 1)
                {
                    Console.WriteLine("Card Value received value outside its range");
                }
                
            }
                    
        }

        private int suit;
        public int Suit
        {
            get
            {
                return (this.suit);
            }
            set
            {
                this.suit = value;
                if (this.suit > 4 || this.suit < 1)
                {
                    Console.WriteLine("Card Suit received value outside its range");
                }

            }

        }

    }
}
