using CMP1903M_A01_2223;
using System;

public class Testing
{
	public Testing()
	{
        string[] Values = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        string[] Suits = { "Clubs", "Hearts", "Diamonds", "Spades" };

        Pack card_pack = new Pack();

        card_pack.shuffleCardPack(2);

        //read all the cards to see if they have been shuffled correctly
        for (int i = 0; i < card_pack.pack.Count; i++)
        {
            Console.WriteLine(Values[card_pack.pack[i].Value] + Suits[card_pack.pack[i].Suit]);
        }
        Console.ReadLine();
    }
}
