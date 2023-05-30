using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                int randnumber = rand.Next(UpWall1.Left + 500, 1700);
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
            SoundPlayer simpleSound = new SoundPlayer(@"c:\University\Programming\2 курс\term2\FinalTestTask\Resources\death.wav");
            simpleSound.Play();
            SavingResults();
            EnterYourNameLabel.Visible = true;
            TextBox.Visible = true;
            TextBox.Enabled = true;
            LostLabel.Visible = true;
            PlayButton.Text = "Replay";
            JumpButton.Enabled = false;
            JumpButton.Visible = false;
            PlayButton.Enabled = true;
            PlayButton.Visible = true;
            timer.Stop();
            timer.Enabled = false;
            ResultsButton.Visible = true;
            ResultsButton.Enabled = true;
        }
        private void BirdIsOutOfBorder()
        {
            if (Bird.Location.Y >= 500 || Bird.Location.Y <= -20)
            {
                Defeat();
            }
        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            //SoundPlayer simpleSound = new SoundPlayer(@"c:\University\Programming\2 курс\term2\FinalTestTask\Resources\mixkit-to-the-next-round-1047.wav");
            //simpleSound.Play();
            if (string.IsNullOrEmpty(TextBox.Text))
            {
                MessageBox.Show("And where is your name?");
                return;
            }
            ResultsButton.Visible = false;
            ResultsButton.Enabled = false;
            TextBox.Visible = false;
            TextBox.Enabled = false;
            score = 0;
            Score.Text = $"Score: {score}";
            Score.Visible = true;
            EnterYourNameLabel.Visible = false;
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
            if (gravityValue > 0)
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
            SoundPlayer simpleSound = new SoundPlayer(@"c:\University\Programming\2 курс\term2\FinalTestTask\Resources\fly.wav"); //
            simpleSound.Play();
        }
        private void Collision(PictureBox a)
        {
            if (!(Bird.Right * 0.99 < a.Left || a.Right < Bird.Left * 0.99))
            {
                if (!(Bird.Bottom * 0.99 < a.Top || a.Bottom * 0.99 < Bird.Top))
                {
                    Defeat();
                }
            }
        }
        private void SavingResults()
        {
            Player p = new Player(TextBox.Text, score);
            using (StreamWriter writer = new StreamWriter(@"C:\University\Programming\2 курс\term2\FinalTestTask\Results.txt", true))
            {
                // Записуємо дані у файл
                writer.WriteLine(p.Tostring());
                // Закриваємо потік запису
                writer.Close();
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
        private void ResultsButton_Click(object sender, EventArgs e)
        {
            if (ResultsButton.Text == "Show all results")
            {
                LostLabel.Visible = false; 
                PlayButton.Visible = false;
                PlayButton.Enabled = false;
                TextBox.Visible = false;
                TextBox.Enabled = false;
                EnterYourNameLabel.Visible = false;
                ResultsButton.Text = "Back to the game";
                listViewResults.Visible = true;
                listViewResults.Enabled = true;
                listViewResults.Items.Clear();
                List<Player> players = new List<Player>();

                
                using (StreamReader reader = new StreamReader(@"C:\University\Programming\2 курс\term2\FinalTestTask\Results.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(":");
                        players.Add(new Player(parts[0], int.Parse(parts[1])));
                    }
                }
                Dictionary<string, Player> uniquePlayers = new Dictionary<string, Player>();
                foreach (Player player in players)
                {
                    if (uniquePlayers.ContainsKey(player.Name))
                    {
                        if (player.Score > uniquePlayers[player.Name].Score)
                        {
                            // Оновити гравця з більшим рахунком
                            uniquePlayers[player.Name] = player;
                        }
                    }
                    else
                    {
                        // Додати гравця з унікальним іменем
                        uniquePlayers.Add(player.Name, player);
                    }
                }
                players = uniquePlayers.Values.ToList();

                players.Sort(); players.Reverse();
                foreach (Player player in players)
                {
                    ListViewItem item = new ListViewItem(player.Name); // Створити новий ListViewItem з ім'ям гравця
                    // Додати решту стовпців даних гравця, наприклад, результата
                    item.SubItems.Add(player.Score.ToString());
                    // Додати ListViewItem до ListView
                    listViewResults.Items.Add(item);
                }
            }
            else if (ResultsButton.Text == "Back to the game")
            {
                ResultsButton.Text = "Show all results";
                PlayButton.Visible = true;
                PlayButton.Enabled = true;
                TextBox.Visible = true;
                TextBox.Enabled = true;
                EnterYourNameLabel.Visible = true;
                listViewResults.Visible = false;
                listViewResults.Enabled = false;
                LostLabel.Visible = true;
            }
            else
            {
                throw new ArgumentException("ResultButtonBug");
            }
        }
    }
}
