using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTestTask
{  
    public partial class MainForm : Form
    {
        int score = 0;
        public double gravity = 1.07;
        public double gravityValue = 5;
        public MainForm()
        {
            InitializeComponent();
        }
        public void MoveWalls()
        {
            UpWall1.Left -= 10;
            DownWall1.Left -= 10;
            UpWall2.Left -= 10;
            DownWall2.Left -= 10;
        }
        public void WallIsOutBorder()
        {
            if (UpWall1.Location.X <= -100)
            {
                Random rand = new Random();
                int randnumber = rand.Next(UpWall2.Left + 500, 1700);
                UpWall1.Left = randnumber;
                DownWall1.Left = randnumber;             
                int y2 = rand.Next(270, 335);
                int y1 = rand.Next(-100, -30);
                UpWall1.Top = y1;
                DownWall1.Top = y2;
            }
            if (UpWall2.Location.X <= -100)
            {
                Random rand = new Random();
                int randnumber = rand.Next(UpWall1.Left+500, 1700);
                UpWall2.Left += randnumber;
                DownWall2.Left += randnumber;               
                int y2 = rand.Next(270, 335);
                int y1 = rand.Next(-100, -30);
                UpWall2.Top = y1;
                DownWall2.Top = y2;
            }
        }
        private void Defeat()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\University\Programming\2 курс\term2\FinalTestTask\Resources\mixkit-boxer-getting-hit-2055.wav");
            simpleSound.Play();
            LostLabel.Visible = true;
            PlayButton.Text = "Replay";
            JumpButton.Enabled = false;
            JumpButton.Visible = false;
            PlayButton.Enabled = true;
            PlayButton.Visible = true;
            timer.Stop();
            timer.Enabled = false;
        }
        private void BirdIsOutOfBorder()
        {
            if(Bird.Location.Y >= 500 || Bird.Location.Y <= -20)
            {              
                Defeat();
            }
        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            //SoundPlayer simpleSound = new SoundPlayer(@"c:\University\Programming\2 курс\term2\FinalTestTask\Resources\mixkit-to-the-next-round-1047.wav");
            //simpleSound.Play();
            score = 0;
            Score.Text = $"Score: {score}";
            Score.Visible = true;
            LostLabel.Visible = false;
            Bird.Top = 128;
            Bird.Left = 171;
            UpWall1.Left = 700;
            DownWall1.Left = 700;
            UpWall2.Left = -100;
            DownWall2.Left = -100;
            PlayButton.Visible = false;
            PlayButton.Enabled = false;
            Bird.Visible = true;
            UpWall1.Visible = true;
            UpWall2.Visible = true;
            DownWall1.Visible = true;
            DownWall2.Visible = true;
            JumpButton.Visible = true;
            JumpButton.Enabled = true;
            timer.Enabled = true;
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {            
            Collision(UpWall1);
            Collision(UpWall2);
            Collision(DownWall1);
            Collision(DownWall2);
            ScoreFunc(UpWall1);
            ScoreFunc(DownWall2);
            BirdIsOutOfBorder();
            WallIsOutBorder();
            MoveWalls();
            Bird.Top += Convert.ToInt32(gravityValue);
            if(gravityValue > 0)
            {
                gravityValue = gravityValue * gravity;
            }
            else
            {
                gravityValue += 6;
            }
        }
        private void JumpButton_Click(object sender, EventArgs e)
        {
            gravityValue = -15;
            SoundPlayer simpleSound = new SoundPlayer(@"c:\University\Programming\2 курс\term2\FinalTestTask\Resources\mixkit-explainer-video-game-alert-sweep-236.wav");
            simpleSound.Play();
        }
        private void Collision(PictureBox a)
        {
            if(!(Bird.Right*0.95 < a.Left || a.Right < Bird.Left))
            {
                if (!(Bird.Bottom * 0.95 < a.Top || a.Bottom * 0.95 < Bird.Top))
                {
                    Defeat();
                }
            }        
        }
        private void ScoreFunc(PictureBox a)
        {
            if (Bird.Right >= a.Left - 5 && Bird.Right <= a.Left + 4) 
            {
                score += 1;
                Score.Text = $"Score: {score}";
            }
        }
    }
}
