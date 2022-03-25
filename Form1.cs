namespace Blackjack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Card card1 = new Card();
            pictureBox1.ImageLocation = card1.image;
            Card card2 = new Card();
            pictureBox2.ImageLocation = card2.image;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Card card = new Card();
            pictureBox1.ImageLocation = card.image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Card card = new Card();
            pictureBox2.ImageLocation = card.image;
        }
    }
}