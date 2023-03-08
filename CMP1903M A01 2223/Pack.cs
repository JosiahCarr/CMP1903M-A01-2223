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
        //changed to public for temp ease of access
        public List<Card> pack = new List<Card>();

        public Pack()
        {
            //Initialise the card pack here

            //the for loop loops through the suits 1 - 4
            for (int i = 0; i < 13; i++) {
                //In every suit 13 cards are added of different values, 1 - 13
                for (int j = 0; j < 4; j++)
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

        // generate a random number from 0 to n, intended to find random locations to shuffle to where n is the length of the pack
        public static int randomNumber(int n)
        {
            Random random = new Random();
            int r = random.Next(0, n);
            return r;
        }

        private static Random random = new Random();


        public static List<Card> swapCards(List<Card>pack, int a, int b)
        {
            Card temp = pack[a];
            pack[a] = pack[b];
            pack[b] = temp;
            return pack;
        }


        // fisher-Yates shuffle
        private static List<Card> fisherYatesShuffle(List<Card> shuffledPack)
        {
            //List<Card> shuffledPack = shuffledPack;

            int length = shuffledPack.Count;
            while (length > 1)
            {
                length--;
                int rand = random.Next(length + 1);
                Card value = shuffledPack[rand];
                shuffledPack[rand] = shuffledPack[length];
                shuffledPack[length] = value;
            }
            
            return shuffledPack;
        }

        
        // riffle shuffle
        private static List<Card> riffleShuffle(List<Card> shuffledPack)
        {

            int lengthRight = shuffledPack.Count;
            int lengthLeft = shuffledPack.Count / 2;

            //riffle shuffle distributes the cards from the left to the right randomly and vice versa
            //in this algorithm the lower index values represent the left and the highest index values represent the right, split
            //cards are shuffled between left and right
            while (lengthLeft > 1)
            {
                lengthLeft--;
                int rand = random.Next(lengthLeft + 1);
                Card left = shuffledPack[rand];
                shuffledPack[rand] = shuffledPack[lengthLeft];
                //set the right hand cards to a random card from the left
                shuffledPack[lengthRight-1] = left;

                int rand2 = random.Next(lengthLeft, lengthRight + 1);
                Card right = shuffledPack[rand2];
                shuffledPack[rand2] = shuffledPack[lengthRight-1];
                //set the left hand cards to a random card from the right
                shuffledPack[lengthLeft] = right;
            }

            return shuffledPack;
        }

        public bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1)
            {
                List<Card> shuffledPack = fisherYatesShuffle(this.pack);
                this.pack = shuffledPack;
            }
            else if (typeOfShuffle == 2)
            {
                List<Card> shuffledPack = riffleShuffle(this.pack);
                this.pack = shuffledPack;
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
        //made non static to take pack
        public Card deal()
        {
            //Deals one card
            Card dealtCard = pack[pack.Count - 1];
            pack.RemoveAt(pack.Count);
            return dealtCard;
        }
        public List<Card> dealCard(int amount)
        {

            //Deals the number of cards specified by 'amount'
            for (int i = pack.Count; i > 1; i--)
            {

            }
            return null;
        }
    }
}
//New class for pile?