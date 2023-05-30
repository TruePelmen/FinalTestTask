
namespace FinalTestTask
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Bird = new System.Windows.Forms.PictureBox();
            this.PlayButton = new System.Windows.Forms.Button();
            this.UpWall1 = new System.Windows.Forms.PictureBox();
            this.UpWall2 = new System.Windows.Forms.PictureBox();
            this.DownWall1 = new System.Windows.Forms.PictureBox();
            this.DownWall2 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.JumpButton = new System.Windows.Forms.Button();
            this.LostLabel = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.EnterYourNameLabel = new System.Windows.Forms.Label();
            this.ResultsButton = new System.Windows.Forms.Button();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.Players = new System.Windows.Forms.ColumnHeader();
            this.ScoreHeader = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownWall2)).BeginInit();
            this.SuspendLayout();
            // 
            // Bird
            // 
            this.Bird.BackColor = System.Drawing.Color.Transparent;
            this.Bird.Image = global::FinalTestTask.Properties.Resources.Bird1;
            this.Bird.Location = new System.Drawing.Point(128, 171);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(48, 48);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 0;
            this.Bird.TabStop = false;
            this.Bird.Visible = false;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayButton.Location = new System.Drawing.Point(363, 171);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(113, 78);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // UpWall1
            // 
            this.UpWall1.BackColor = System.Drawing.Color.Transparent;
            this.UpWall1.Image = ((System.Drawing.Image)(resources.GetObject("UpWall1.Image")));
            this.UpWall1.Location = new System.Drawing.Point(488, -70);
            this.UpWall1.Name = "UpWall1";
            this.UpWall1.Size = new System.Drawing.Size(71, 217);
            this.UpWall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpWall1.TabIndex = 2;
            this.UpWall1.TabStop = false;
            this.UpWall1.Visible = false;
            // 
            // UpWall2
            // 
            this.UpWall2.BackColor = System.Drawing.Color.Transparent;
            this.UpWall2.Image = ((System.Drawing.Image)(resources.GetObject("UpWall2.Image")));
            this.UpWall2.Location = new System.Drawing.Point(768, -116);
            this.UpWall2.Name = "UpWall2";
            this.UpWall2.Size = new System.Drawing.Size(71, 217);
            this.UpWall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpWall2.TabIndex = 3;
            this.UpWall2.TabStop = false;
            this.UpWall2.Visible = false;
            // 
            // DownWall1
            // 
            this.DownWall1.BackColor = System.Drawing.Color.Transparent;
            this.DownWall1.Image = ((System.Drawing.Image)(resources.GetObject("DownWall1.Image")));
            this.DownWall1.Location = new System.Drawing.Point(488, 330);
            this.DownWall1.Name = "DownWall1";
            this.DownWall1.Size = new System.Drawing.Size(71, 217);
            this.DownWall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownWall1.TabIndex = 4;
            this.DownWall1.TabStop = false;
            this.DownWall1.Visible = false;
            // 
            // DownWall2
            // 
            this.DownWall2.BackColor = System.Drawing.Color.Transparent;
            this.DownWall2.Image = ((System.Drawing.Image)(resources.GetObject("DownWall2.Image")));
            this.DownWall2.Location = new System.Drawing.Point(768, 330);
            this.DownWall2.Name = "DownWall2";
            this.DownWall2.Size = new System.Drawing.Size(71, 217);
            this.DownWall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownWall2.TabIndex = 5;
            this.DownWall2.TabStop = false;
            this.DownWall2.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // JumpButton
            // 
            this.JumpButton.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JumpButton.Location = new System.Drawing.Point(675, 171);
            this.JumpButton.Name = "JumpButton";
            this.JumpButton.Size = new System.Drawing.Size(113, 78);
            this.JumpButton.TabIndex = 8;
            this.JumpButton.Text = "Jump";
            this.JumpButton.UseVisualStyleBackColor = true;
            this.JumpButton.Visible = false;
            this.JumpButton.Click += new System.EventHandler(this.JumpButton_Click);
            // 
            // LostLabel
            // 
            this.LostLabel.AutoSize = true;
            this.LostLabel.BackColor = System.Drawing.Color.Transparent;
            this.LostLabel.Font = new System.Drawing.Font("Swis721 Hv BT", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LostLabel.Location = new System.Drawing.Point(348, 267);
            this.LostLabel.Name = "LostLabel";
            this.LostLabel.Size = new System.Drawing.Size(146, 27);
            this.LostLabel.TabIndex = 9;
            this.LostLabel.Text = "You Lost =(";
            this.LostLabel.Visible = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Location = new System.Drawing.Point(12, 23);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(61, 20);
            this.Score.TabIndex = 10;
            this.Score.Text = "Score: 0";
            this.Score.Visible = false;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(357, 120);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(125, 27);
            this.TextBox.TabIndex = 11;
            // 
            // EnterYourNameLabel
            // 
            this.EnterYourNameLabel.AutoSize = true;
            this.EnterYourNameLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.EnterYourNameLabel.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterYourNameLabel.Location = new System.Drawing.Point(305, 85);
            this.EnterYourNameLabel.Name = "EnterYourNameLabel";
            this.EnterYourNameLabel.Size = new System.Drawing.Size(219, 32);
            this.EnterYourNameLabel.TabIndex = 12;
            this.EnterYourNameLabel.Text = "Enter your name";
            // 
            // ResultsButton
            // 
            this.ResultsButton.Location = new System.Drawing.Point(12, 363);
            this.ResultsButton.Name = "ResultsButton";
            this.ResultsButton.Size = new System.Drawing.Size(116, 58);
            this.ResultsButton.TabIndex = 13;
            this.ResultsButton.Text = "Show all results";
            this.ResultsButton.UseVisualStyleBackColor = true;
            this.ResultsButton.Click += new System.EventHandler(this.ResultsButton_Click);
            // 
            // listViewResults
            // 
            this.listViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Players,
            this.ScoreHeader});
            this.listViewResults.Enabled = false;
            this.listViewResults.HideSelection = false;
            this.listViewResults.Location = new System.Drawing.Point(241, 47);
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(379, 310);
            this.listViewResults.TabIndex = 14;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.View = System.Windows.Forms.View.Details;
            this.listViewResults.Visible = false;
            // 
            // Players
            // 
            this.Players.Text = "Players";
            this.Players.Width = 200;
            // 
            // ScoreHeader
            // 
            this.ScoreHeader.Text = "Score";
            this.ScoreHeader.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::FinalTestTask.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultsButton);
            this.Controls.Add(this.JumpButton);
            this.Controls.Add(this.EnterYourNameLabel);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.LostLabel);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.listViewResults);
            this.Controls.Add(this.UpWall1);
            this.Controls.Add(this.DownWall1);
            this.Controls.Add(this.UpWall2);
            this.Controls.Add(this.DownWall2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Flappy Bird";
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownWall2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.PictureBox UpWall1;
        private System.Windows.Forms.PictureBox UpWall2;
        private System.Windows.Forms.PictureBox DownWall1;
        private System.Windows.Forms.PictureBox DownWall2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button JumpButton;
        private System.Windows.Forms.Label LostLabel;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label EnterYourNameLabel;
        private System.Windows.Forms.Button ResultsButton;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.ColumnHeader Players;
        private System.Windows.Forms.ColumnHeader ScoreHeader;
    }
}

