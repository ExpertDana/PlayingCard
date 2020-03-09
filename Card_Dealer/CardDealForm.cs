using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayingCards;

namespace Card_Dealer
{
    public partial class CardDealForm : Form
    {
        private Deck deck;
        public CardDealForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PictureBoxDeck.Image = imageList1.Images[54];
            // deck = new Deck();
            deck = new Deck(CardRank.Ace,CardRank.Two, CardRank.Three, CardRank.Four, CardRank.Five, CardRank.Six, CardRank.Jack, CardRank.Queen, CardRank.King);
            List<Image> list = new List<Image>();
            for (int i = 0; i < 52; i++) 
            {
                list.Add(imageList1.Images[i]);
                
            }
            deck.AssignImages(list, imageList1.Images[54]);
            deck.Shuffle();

        }

        private void PictureBoxDeck_Click(object sender, EventArgs e)
        {
            if (!deck.isEmpty())
            {
                PlayingCard card = deck.DealTopCard();
                PictureBoxCard.Image = card.FrontImage;
            }
            
            

        }

        private void PictureBoxCard_Click(object sender, EventArgs e)
        {

        }
    }
}
