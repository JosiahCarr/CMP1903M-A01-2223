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
    class Shuffles
    {
        public Shuffles()
        {

        }
        private static Random random = new Random();

        // fisher-Yates shuffle
        public static List<Card> fisherYatesShuffle(List<Card> shuffledPack)
        {
            //the fisher yates shuffle works its way from top to bottom swapping all cards with random other cards
            int length = shuffledPack.Count;
            int lengthIterator = length;
            while (lengthIterator > 0)
            {
                //try catch error handling is used in the event that an index value is out of range
                //this can also be considered a form of incapsulation, however it is not often what is reffered to by encapsulation,
                //the try catch, encapulates the error, seperating it from the rest of the entire program, if dealt with correctly it can
                //save the program from crashing
                try
                {
                    lengthIterator--;
                    int rand = random.Next(length);
                    Card value = shuffledPack[rand];
                    shuffledPack[rand] = shuffledPack[lengthIterator];
                    shuffledPack[lengthIterator] = value;
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
                    return null;
                }
            }

            return shuffledPack;
        }


        // riffle shuffle
        static List<Card> riffleShuffle(List<Card> shuffledPack)
        {
            //riffle shuffle distributes the cards from the left to the right randomly and vice versa
            //in this algorithm the lower index values represent the left and the highest index values represent the right, split
            //cards are shuffled between left and right

            //the variables below declare the start and end index points that define left shuffle and right shuffle
            int lengthRight = shuffledPack.Count;
            int lengthLeft = shuffledPack.Count / 2;

            //the variables below are duplicates of the above, except that these will be used as the iterators for the loop, and will decrease, untill the loop breaks
            int leftIterate = lengthLeft;
            int rightIterate = lengthRight;

            try
            {
                while (rightIterate > lengthLeft)
                {
                    //iterators are decreased for left and right side, they will decrease untill every card on each side has been shuffled
                    leftIterate--;
                    rightIterate--;

                    //Console.WriteLine($"{leftIterate} {rightIterate}");

                    int rand = random.Next(0, lengthLeft); //generates a random place on the left to switch with the designated right card

                    Card left = shuffledPack[rand]; //the random left position is coppied as a temp so it can be replaced with the right hand card
                    shuffledPack[rand] = shuffledPack[rightIterate]; //card on the left is replaced with the right and its old card is stored in a temp obj
                    shuffledPack[rightIterate] = left; //the temp Card from the left is now assigned to the right, completing 1 swap

                    //the rest of the for loop is a repetition of the previous, however, it distributes the left cards to random places on the right
                    int rand2 = random.Next(lengthLeft, lengthRight);

                    Card right = shuffledPack[rand2];
                    shuffledPack[rand2] = shuffledPack[leftIterate];
                    shuffledPack[leftIterate] = right;
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
                return null;
            }



            lengthLeft = shuffledPack.Count / 2;

            return shuffledPack;
        }
    }
    

}


	