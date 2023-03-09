using CMP1903M_A01_2223;
using System;
using System.Collections.Generic;

internal static class CardPile
{
    //new class added to hold the dealt cards, more classes means more encapsulation and increased security of data
    //as 

    //create an empty pile of cards, this will be where the cards are dealt to
    // private declaration provides even more encapsulation meaning the list cannot be manipulated as easily
    private static List<Card> pile = new List<Card>(); 

    //public CardPile()
    
    
    /**
    public List<Card> addCard()
    {
        pile.Add(card);
        return pile;
    }**/
}
