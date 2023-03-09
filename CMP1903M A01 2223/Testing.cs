using CMP1903M_A01_2223;
using System;
using System.Collections.Generic;

public class Testing
{
	public Testing()
	{
        //For convenience and ease understanding string lists have been used to display the actual values as the cards (only for testing)
        //the purpose of these strings are a form of Abstraction as the problem's technical side is hidden and its presented in a more 
        //meaningful and understandable form, making it easy to test 
        string[] Values = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        string[] Suits = { "Clubs", "Hearts", "Diamonds", "Spades" };

        //Shuffles shuffle = new Shuffles();
        //Pack cardPack = new Pack();

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
        if (deal != null) //check if card is valid
        {
            Console.WriteLine("Dealt Card: ", deal.Value, deal.Suit);
        }

        List<Card> dealtCards = Pack.dealCard(7);
        if (dealtCards != null) //check if cards are valid
        {
            Console.WriteLine("\n Pack: ");
            for (int i = 0; i < Pack.pack.Count; i++)
            {
                
                Console.WriteLine(Values[Pack.pack[i].Value - 1] + " " + Suits[Pack.pack[i].Suit - 1]);
            }
            Console.WriteLine("\n Dealt cards: ");
            for (int i = 0; i < dealtCards.Count; i++)
            {
                
                Console.WriteLine(Values[dealtCards[i].Value - 1] + " " + Suits[dealtCards[i].Suit - 1]);
            }
        }

        //Shuffles shuffles = new Shuffles ();
        Console.ReadLine();


    }
}
