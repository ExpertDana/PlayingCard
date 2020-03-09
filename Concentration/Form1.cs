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
using System.Timers;
using System.IO;

namespace Concentration
{
    public partial class Form1 : Form
    {
        const int CARD_BACK = 54;
        const int NUM_CARDS = 32;
        const int NUM_COLS = 8;
        const int CARD_WIDTH = 75;
        const int CARD_HEIGHT = 107;
        Deck deck;
        PictureBox[] cardImages;

        PictureBox firstCardImage;
        PictureBox secondCardImage;
        int stage;

        TimeSpan counttime = new TimeSpan(0, 2, 00);
        Label TimeLabel = new Label();
        Label HighScore = new Label();
        Label PlayerScore1 = new Label();
        Label PlayerScore2 = new Label();
        Label PlayerScore3 = new Label();
        int numOfCardCleared = 0;

        int playerscore;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // timercount.Enabled = true;
            timercount.Interval = 1000;
            timer.Interval = 500;
            stage = 0;
            HighScore.Text = "LEADERBOARD";
            HighScore.Location = new Point(NUM_COLS * (CARD_WIDTH + 20) + 330, 55);
            HighScore.AutoSize = true;
            HighScore.Font = new Font("Calibri", 24);
            this.Controls.Add(HighScore);
            deck = new Deck(CardRank.Two, CardRank.Three, CardRank.Four, CardRank.Five, CardRank.Six, CardRank.Jack, CardRank.Queen, CardRank.King);
            List<Image> list = new List<Image>();




            for (int i = 0; i < 52; i++)
            {
                list.Add(imageList1.Images[i]);
            }

            deck.AssignImages(list, imageList1.Images[CARD_BACK]);
            deck.Shuffle();
            cardImages = new PictureBox[NUM_CARDS];


            for (int i = 0; i < NUM_CARDS; i++)
            {
                cardImages[i] = new PictureBox();

                PlayingCard card = deck.DealTopCard();

                cardImages[i].Tag = card;
                cardImages[i].Size = new Size(CARD_WIDTH, CARD_HEIGHT);
                int col = i % NUM_COLS;
                int row = i / NUM_COLS;
                cardImages[i].Location = new Point(col * (CARD_WIDTH + 20) + 50, row * (CARD_HEIGHT + 20) + 50);

                cardImages[i].Image = card.GetImage();
                cardImages[i].Click += Card_Click;
                Controls.Add(cardImages[i]);

                TimeLabel.Text = counttime.Hours.ToString() + ":" + counttime.Minutes.ToString() + ":" + counttime.Seconds.ToString();
                TimeLabel.Location = new Point(NUM_COLS * (CARD_WIDTH + 20) + 50, 55);
                TimeLabel.AutoSize = true;
                TimeLabel.Font = new Font("Calibri", 58);
                TimeLabel.BorderStyle = BorderStyle.Fixed3D;
                TimeLabel.ForeColor = Color.Blue;
                TimeLabel.BackColor = Color.Aqua;
                this.Controls.Add(TimeLabel);

                //HighScore.Text = "Leaderboard";
                //HighScore.Location=new Point(NUM_COLS * (CARD_WIDTH + 20) + 350, 55);
                //HighScore.AutoSize = true;
                //HighScore.Font = new Font("Calibri",20);
                //this.Controls.Add(HighScore);



            }

        }


        private void Form1_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        void Card_Click(object sender, EventArgs e)
        {
            timercount.Start();
            PictureBox box = sender as PictureBox;
            PlayingCard card = box.Tag as PlayingCard;

            card.Flip();



            box.Image = card.GetImage();
            if (stage % 2 == 0)
            {
                stage++;
                firstCardImage = box;
                firstCardImage.Enabled = false;

            }
            else
            {
                stage++;
                secondCardImage = box;
                secondCardImage.Enabled = false;

                timer.Start();
                Form1.ActiveForm.Enabled = false;
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            firstCardImage.Enabled = true;
            secondCardImage.Enabled = true;
            PlayingCard Card1 = firstCardImage.Tag as PlayingCard;
            PlayingCard Card2 = secondCardImage.Tag as PlayingCard;
            Form1.ActiveForm.Enabled = true;
            if (Card1.Rank == Card2.Rank)
            {

                firstCardImage.Visible = false;
                secondCardImage.Visible = false;
                numOfCardCleared += 2;

                if (numOfCardCleared == NUM_CARDS)
                {
                    timercount.Stop();

                    MessageBox.Show("your score is " + " " + playerscore + " seconds");
                    this.Close();
                }
            }
            else
            {
                Card1.Flip();
                firstCardImage.Image = Card1.GetImage();
                Card2.Flip();
                secondCardImage.Image = Card2.GetImage();
            }

        }

         
        private void Top3Player()
        {

            
            var Top3player = new List<Tuple<string, int>>();
           
            using (StreamReader sr=new StreamReader(@"H:\2020IT\IT607C#\Leaderboard.txt"))
           {
                while (!sr.EndOfStream) 
                {
                    string line = sr.ReadLine();
                    string[] parts = line.Split('$');
                    Top3player.Add(Tuple.Create(parts[0],int.Parse(parts[1])));

                }
             }

            foreach (var item in Top3player)
            {
                string s = item.Item1;
                int i = item.Item2;

            }

            Top3player.Add(Tuple.Create("Player",playerscore));

            Top3player.Sort();

            PlayerScore1.Text = string.Format("{0}  {1}",Top3player[0].Item1,Top3player[0].Item2);
               
            PlayerScore1.Location = new Point(NUM_COLS * (CARD_WIDTH + 20) + 335, 120);
            PlayerScore1.Font = new Font("Calibri", 18);
            PlayerScore1.AutoSize = true;
            PlayerScore1.ForeColor = Color.Goldenrod;
            this.Controls.Add(PlayerScore1);
            PlayerScore2.Text = string.Format("{0}  {1}",Top3player[1].Item1,Top3player[1].Item2);
            PlayerScore2.Location = new Point(NUM_COLS * (CARD_WIDTH + 20) + 335, 160);
            PlayerScore2.Font = new Font("Calibri", 18);
            PlayerScore2.AutoSize = true;
            PlayerScore2.ForeColor = Color.Silver;
            this.Controls.Add(PlayerScore2);
            PlayerScore3.Text = string.Format("{0}  {1}",Top3player[2].Item1,Top3player[2].Item2);
            PlayerScore3.Location = new Point(NUM_COLS * (CARD_WIDTH + 20) + 335, 200);
            PlayerScore3.Font = new Font("Calibri", 18);
            PlayerScore3.AutoSize = true;
            //PlayerScore3.ForeColor = Color.Brown;
            this.Controls.Add(PlayerScore3);
        }

        private void timercount_Tick_1(object sender, EventArgs e)
        {
            counttime = counttime.Subtract(new TimeSpan(0, 0, 1));
            playerscore = 120 - (Convert.ToInt32((counttime.Minutes * 60) + (counttime.Seconds)));

            Top3Player();
            TimeLabel.Text = counttime.Hours.ToString() + ":" + counttime.Minutes.ToString() + ":" + counttime.Seconds.ToString();
            if (counttime.TotalSeconds < 0.1)
            {
                timercount.Enabled = false;
                MessageBox.Show("Time is up!");
                this.Close();


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



