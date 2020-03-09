using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace PlayingCards
{
   public class PlayingCard
    {
        public CardRank Rank { get; set; }
        public CardSuit Suit { get; set; }
        public int points{get;set;}
        public bool IsFaceUp{get;set;}
        public Image FrontImage{get;set;}
        public Image BackImage{get;set;}
        public  int ID{get;set;}
        public string Name{get;set;}
        public string Abbrew{get;set;}
        
        public  PlayingCard(CardSuit suit, CardRank rank)
        {
            Rank = rank;
            Suit = suit;
            points=0;
            IsFaceUp =false;
            FrontImage=null;
            BackImage =null;
            ID= CalculateID();
            Name=ToString();
            Abbrew=GetDefaultAbbrev();
            
        }
       
        
        public int  CalculateID()
        {    
            int x=(int)Suit*13;
            int y=(int)Rank;
            return x+y;
        }
        
        public string  GetDefaultAbbrev()
        {
           
            
            char su=Suit.ToString()[0];
          
            if((int)Rank>=8)
            {
              char rc=Rank.ToString()[0];
                return  string.Format("{0}{1}",rc,su);
            }
             else
            {
              int ri=(int)(Rank+2);
                return string.Format("{0}{1}",ri,su);
            }
            
        }
        public void Flip( )
       {
          IsFaceUp = ! IsFaceUp;
       }

        public Image GetImage()
        {
            if(IsFaceUp==true)
            {
                return FrontImage;
            }
            else 
            {
                return BackImage;
            }
        }

     
    

        public override string ToString()
        {
            return string.Format("{0} of {1}",Rank,Suit);
        }
        
    }
}
    
    

