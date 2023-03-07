using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack = new List<Card>();

        public Pack()
        {
            //Initialise the card pack here

            //the for loop loops through the suits 1 - 4
            for (int i = 1; i <= 4; i++) {
                //In every suit 13 cards are added of different values, 1 - 13
                for (int j = 1; j <= 13; j++)
                {
                    //Every card that is created is sent to the pack list with i and j as arguments in the format Suit, Value
                    pack.Add(new Card(i, j));
                }
                    
            }

            Console.WriteLine("The pack");
            Console.WriteLine(pack);

        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            return false;
        }
        public static Card deal()
        {
            //Deals one card
            return null;
        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            return null;
        }
    }
}
/*

{
    Deck deck = new Deck();
    System.Console.WriteLine(deck);
}
}

public class Deck
{
    public List<Card> Cards = new List<Card>();

    public Deck()
    {
        string[] ranks = { "Ace", "Two", "Three", "Four", "Five" };
        string[] suits = { "Diamonds", "Hearts", "Clubs", "Spades" };

        foreach (string suit in suits)
        {
            foreach (string rank in ranks)
            {
                Card card = new Card(rank, suit);
                Cards.Add(card);
            }
        }
    }

    public override string ToString()
    {
        return Cards.ToString();
    }
*/