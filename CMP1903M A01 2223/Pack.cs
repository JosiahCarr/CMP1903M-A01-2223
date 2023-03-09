using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        //the pack is made static, as there will only be one pack as stated in the docemnt brief, it is also public, however, 
        //this is not the best in terms of encapsulation as it can be accessed from anywhere
        public static List<Card> pack = new List<Card>();

        public Pack()
        {
            //Initialise the card pack here

            //the for loop loops through the suits 1 - 4
            for (int i = 1; i <= 13; i++)
            {
                //In every suit 13 cards are added of different values, 1 - 13
                for (int j = 1; j <= 4; j++)
                {
                    //Every card that is created is sent to the pack list with i and j as arguments in the format Value, Suit
                    Card card = new Card();
                    card.Value = i;
                    card.Suit = j;
                    pack.Add(card);
                    //pack.Add(new Card(i, j));
                }

            }

        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            //Shuffles shuffles = new Shuffles();
            if (typeOfShuffle == 1)
            {
                List<Card> shuffledPack = Shuffles.fisherYatesShuffle(pack);
                Console.WriteLine(shuffledPack);
                pack = shuffledPack;
                //return true;
            }
            else if (typeOfShuffle == 2)
            {
                List<Card> shuffledPack = Shuffles.riffleShuffle(pack);
                pack = shuffledPack;
                //return true;
            }
            else if (typeOfShuffle == 3)
            {
                return false;
            }
            else
            {
                Console.WriteLine("shuffleCardPack should only receive 1, 2 or 3, but another value was recieved");
            }

            return false;

        }

        public static Card deal()
        {
            if (Pack.pack.Count > 0) // first check if there are enough cards to deal
            {
                //Deals one card
                Card dealtCard = pack[0];
                pack.RemoveAt(0);
                return dealtCard;
            }
            else { return null; }

        }

        public static List<Card> dealCard(int amount)
        {
            List<Card> cardsDealt = new List<Card>();

            if (Pack.pack.Count >= amount)// check if there are enough cards to deal
            {
                //Deals the number of cards specified by 'amount'
                for (int i = 0; i < amount; i++)
                {
                    Card dealtCard = pack[0];
                    pack.RemoveAt(0);
                    cardsDealt.Add(dealtCard);

                }
                return cardsDealt;
            }
            else { return null; }

        }
    }
}
