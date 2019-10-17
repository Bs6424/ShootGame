using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ShootGame
{
    public partial class Form1 : Form
    {
        ShootLogic game = new ShootLogic(); //Defining the object of Game inm GameRR class
        Random randshoot = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadBtn.Enabled = false;
            SpinBtn.Enabled = true;
            FireBtn.Enabled = false;
            FireAwayBtn.Enabled = false;
            pictureBox1.Image = ShootGame.Resource1.LoadImg;
            SoundPlayer player = new SoundPlayer(ShootGame.Resource1.load);
            player.Play();

        }

        private void SpinBtn_Click(object sender, EventArgs e)
        {
            LoadBtn.Enabled = false;
            SpinBtn.Enabled = false;
            FireBtn.Enabled = true;
            FireAwayBtn.Enabled = true;
            pictureBox1.Image = ShootGame.Resource1.SpinImg;
            SoundPlayer player = new SoundPlayer(ShootGame.Resource1.spin);
            player.Play();
            game.Bullet = randshoot.Next(1, 6);
        }

        private void FireBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ShootGame.Resource1.Shot;
            SoundPlayer player = new SoundPlayer(ShootGame.Resource1.fire);
            player.Play();
            if (game.TotalBullet > 0 && game.Bullet == 1)
            {
                MessageBox.Show("You Lost");

                LoadBtn.Enabled = false;
                SpinBtn.Enabled = false;
                FireBtn.Enabled = false;
                FireAwayBtn.Enabled = false;
            }

            else if (game.TotalBullet > 0 && game.Bullet != 1)
            {
                game.TotalBullet = game.TotalBullet - 1;

                game.Bullet = game.Spin(game.Bullet);
                MessageBox.Show("No Bullet");
            }
        }

        private void FireAwayBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ShootGame.Resource1.ShootAway;
            SoundPlayer player = new SoundPlayer(ShootGame.Resource1.fire);
            player.Play();
            if (game.FireAwayChance >= 1)
            {
                int score = game.FireAway();
                if (score == 100)
                {
                    MessageBox.Show("Your score is 100");
                   
                    FireAwayBtn.Enabled = false;
                    SpinBtn.Enabled = true;
                    FireBtn.Enabled = false;
                    LoadBtn.Enabled = false;
                }
                if (score == 50)
                {
                    MessageBox.Show( "Your score is 50");
                    
                    FireAwayBtn.Enabled = false;
                    SpinBtn.Enabled = true;
                    FireBtn.Enabled = false;
                    LoadBtn.Enabled = false;
                }
                if (score == 0)
                {
                    MessageBox.Show("Champer Empty");
                    if (game.TotalBullet == 0)
                    {
                        MessageBox.Show("you lost");
                        FireAwayBtn.Enabled = false;

                    }

                }
            }
            else
            {
                MessageBox.Show("you have already lost 2 life line");
                FireAwayBtn.Enabled = false;
            }

        }

    
    
        private void ReStartBtn_Click(object sender, EventArgs e)
        {
            (new Form1()).Show();
            this.Hide();
            LoadBtn.Enabled = true;
            SpinBtn.Enabled = false;
            FireBtn.Enabled = false;
            FireAwayBtn.Enabled = false;
            ReStartBtn.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
