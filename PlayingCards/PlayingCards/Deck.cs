using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PlayingCards
{
    public class Deck
    {
        public List<PlayingCard> cards = new List<PlayingCard>();
        public static Random rnd=new Random();

        public Deck(params CardRank[] ranks)
       { 
            for(CardSuit suit=CardSuit.Clubs;suit <= CardSuit.Spades;suit++)

            { 
               for (CardRank rank = CardRank.Two; rank <= CardRank.Ace; rank++) 
                { 
                    if(ranks.Length==0||ranks.Contains(rank))
                    {
                        cards.Add(new PlayingCard(suit,rank));
                    }

                    
                }

            }
           
       }

        public Deck()
        { 
             for(CardSuit suit=CardSuit.Clubs;suit <= CardSuit.Spades;suit++)

            { 
               for (CardRank rank = CardRank.Two; rank <= CardRank.Ace; rank++) 
                { 

                    cards.Add(new PlayingCard(suit,rank));
                }

            }
                
        }

        public bool isEmpty()
        {
            if 
                (cards.Count() == 0)
            { 
                
                return true;
            }
            else 
            {
                return false;
            }
        }

        public PlayingCard DealTopCard()
        {
            if (isEmpty()) 
            {
                return null; 
            }
            else 
            { 
           
            PlayingCard theTopCard = cards[0];
            cards.RemoveAt(0);
            return theTopCard;
            }
        }
        public void Shuffle()
        {  //swap cards form front to back in the deck
            for(int i=0;i<cards.Count-2;i++)
            {
                int pos = rnd.Next(i+1,cards.Count);
                //return a random number form second front card to the last card.randdom.next(include,notinclude)
                PlayingCard tmp = cards[i];
                cards[i] = cards[pos];//swap the random card and the front card
                cards[pos] = tmp;

            }

        }
        public void AssignImages(List<Image> faces, Image back)//assign the front and back Image to the card.
        {
            
            for(int i=0;i<cards.Count;i++)
            {
                cards[i].FrontImage=faces[cards[i].ID];
                cards[i].BackImage=back;

            }
        }

    }
}
