using CMP1903M_A01_2223;
using System;

public class Testing
{
	public Testing()
	{
        //For convenience and ease understanding string lists have been used to display the actual values as the cards (only for testing)
        //the purpose of these strings are a form of Abstraction as the problem's technical side is hidden and its presented in a more 
        //meaningful and understandable form, making it easy to test 
        string[] Values = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        string[] Suits = { "Clubs", "Hearts", "Diamonds", "Spades" };

        //Pack cardPack = new Pack();
        Shuffles shuffle = new Shuffles();

        Pack.shuffleCardPack(1); //test the fisher Yates shuffle 
        Pack.shuffleCardPack(2); //test the riffle shuffle
        Pack.shuffleCardPack(3); //test no shuffle
        Pack.shuffleCardPack(4); //test an unexpected value 

        //read all the cards to see if they have been shuffled correctly
        for (int i = 0; i < Pack.pack.Count; i++)
        {
            Console.WriteLine(Values[Pack.pack[i].Value-1] + " " + Suits[Pack.pack[i].Suit-1]); //present the card in a easy to understand form
        }

        Card deal = Pack.deal();
        Console.WriteLine("Dealt Card: ", deal.Value, deal.Suit);

        //Shuffles shuffles = new Shuffles ();
        Console.ReadLine();


    }
}
