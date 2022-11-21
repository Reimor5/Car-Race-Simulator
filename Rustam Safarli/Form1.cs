using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rustam_Safarli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
     
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            pictureBox1.Left += rand.Next(5, 15);
            pictureBox2.Left += rand.Next(5, 15);
            if (pictureBox1.Left > 640)
            {
                timer1.Stop();
                textBox3.BackColor = Color.Blue;
                MessageBox.Show("That white Fiat Pinto just wrecked this race");


            }
            else if (pictureBox2.Left > 640)
            {
                timer1.Stop();
                textBox3.BackColor = Color.Red;
                MessageBox.Show("Cooler Red Fiat Pinto won the race!");

            }
            else if (pictureBox1.Left == 640 || pictureBox2.Left == 640)
            {
                timer1.Stop();
                textBox3.BackColor = Color.Yellow;
                MessageBox.Show("Go hang youself! (just kidding it's a draw");

            }
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(21, 69);
            pictureBox2.Location = new Point(21, 286);
            textBox3.BackColor = Color.White;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
