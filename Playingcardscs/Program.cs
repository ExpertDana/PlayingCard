using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayingCards;

namespace PlayingCardscs
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck x = new Deck();
            x.Shuffle();
           
            for(int i= 0; i<52; i++) 
            {  
                Console.WriteLine(x.DealTopCard().GetDefaultAbbrev());
                //Console.WriteLine(x.cards.Count());

            }




            Console.ReadLine();


        }


    }
}
