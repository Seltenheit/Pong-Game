using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Po_n_g
{
    public partial class POnG : Form
    {
        private int verticalSpeed = 4;
        private int horizontalSpeed = 4;
        private int score = 0;
        private bool lost = false;
        private bool menuIsOpen = false;
        private bool isOnPause = false;

        public POnG()
        {
            InitializeComponent();

            this.Bounds = Screen.PrimaryScreen.Bounds;

            SetPanels();

            Timer.Enabled = true;

            //this.FormBorderStyle = FormBorderStyle.None;
            //this.TopMost = true;
        }
        private void SetPanels()
        {
            OnPause.Visible = false;
            GameOver.Visible = false;
            RestartButton.Visible = false;
            MenuBox.Visible = false;
            SettingsPanel.Visible = false;

            Cursor.Hide();

            GamePanel.Top = Background.Bottom - (Background.Bottom / 10);

            SettingsPanel.Left = (Background.Width / 2) - (SettingsPanel.Width / 2);
            SettingsPanel.Top = (Background.Height / 2) - (SettingsPanel.Height / 2);

            MenuBox.Left = (Background.Width / 2) - (MenuBox.Width / 2);
            MenuBox.Top = (Background.Height / 2) - (MenuBox.Height / 2);

            GameOver.Left = (Background.Width / 2) - (GameOver.Width / 2);
            GameOver.Top = (Background.Height / 2) - (GameOver.Height / 2);

            RestartButton.Left = (Background.Width / 2) - (RestartButton.Width / 2);
            RestartButton.Top = GameOver.Top + GameOver.Height + 2;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                OpenMenu();
            }

            if (e.KeyCode == Keys.P)
            {
                Pause();

            }

            if (e.KeyCode == Keys.R)
            {
                if (lost == true)
                    Restart();
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            GamePanel.Left = Cursor.Position.X - (GamePanel.Width / 2);

            Ball.Left += horizontalSpeed;
            Ball.Top += verticalSpeed;

            if (Ball.Left <= Background.Left)
                horizontalSpeed *= -1;
            if (Ball.Right >= Background.Right)
                horizontalSpeed *= -1;

            if (Ball.Top <= Background.Top)
                verticalSpeed *= -1;
            if (Ball.Bottom >= Background.Bottom)
                Lose();

            if(Ball.Bounds.IntersectsWith(GamePanel.Bounds))
            {
                Balled();
                ChangeBackground();
            }
           

            //if (Ball.Bottom > GamePanel.Top && Ball.Bottom <= GamePanel.Bottom
            //    && Ball.Left >= GamePanel.Left && Ball.Right <= GamePanel.Right)
            //{
            //    Balled();

            //    ChangeBackground();
            //}
        }

        internal void ChangeBackground()
        {
            Random randColor = new Random();

            Background.BackColor = Color.FromArgb(randColor.Next(150, 255), randColor.Next(150, 255), randColor.Next(150, 255));
        }

        internal void Balled()
        {
            horizontalSpeed += 1;
            verticalSpeed += 1;
            verticalSpeed *= -1;
            score += 1;
            Result.Text = "Result: " + score.ToString();
            if (score >= 10)
                Ball.BackgroundImage = Ball.ErrorImage;
        }





        private void MenuButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void MenuButton_MouseClick(object sender, MouseEventArgs e)
        {
            OpenMenu();
            SettingsPanel.Hide();
        }

        private void PauseButton_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void PauseButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            Pause();
        }
        private void RestartButton_Click(object sender, EventArgs e)
        {
            Restart();
        }




        private void ExitButton_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            OpenMenu();
            SettingsPanel.Hide();
        }




        private void OpenMenu()
        {
            if (lost)
            {
                MenuBox.Show();
                menuIsOpen = true;
                RestartButton.Hide();
                GameOver.Hide();
            }
            else if (menuIsOpen == false && isOnPause == false)
            {
                MenuBox.Show();
                menuIsOpen = true;
                Pause();
            }
            else if (menuIsOpen == false && isOnPause)
            {
                MenuBox.Show();
                menuIsOpen = true;
            }
            else if (menuIsOpen && isOnPause)
            {
                MenuBox.Hide();
                menuIsOpen = false;
                Pause();
            }


        }

        private void Pause()
        {
            if (Timer.Enabled)
            {
                Cursor.Show();
                Timer.Stop();
                OnPause.Show();
                isOnPause = true;
            }
            else if (Timer.Enabled == false && lost == false && menuIsOpen == false)
            {
                Timer.Enabled = true;
                OnPause.Hide();
                Cursor.Hide();
                isOnPause = false;
            }
        }

        private void Restart()
        {
            Ball.Top = 50;
            Ball.Left = 70;
            horizontalSpeed = 4;
            verticalSpeed = 4;
            score = 0;
            Result.Text = "Result: 0";

            lost = false;
            Timer.Enabled = true;
            menuIsOpen = false;
            isOnPause = false;

            RestartButton.Hide();
            GameOver.Hide();
            Cursor.Hide();
            MenuBox.Hide();
            OnPause.Hide();
            SettingsPanel.Hide();

            ResumeButton.Cursor = Cursors.Hand;
            ResumeButton.ForeColor = default;
            Background.BackColor = default;
            Ball.BackgroundImage = default;
        }

        private void Lose()
        {
            Timer.Enabled = false;
            lost = true;

            Cursor.Show();
            GameOver.Show();
            RestartButton.Show();
            ResumeButton.ForeColor = Color.DarkGray;
            ResumeButton.Cursor = default;
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsPanel.Show();
            SettingsPanel.BringToFront();
           
        }

        private void SettingsCloseButton_Click(object sender, EventArgs e)
        {
            SettingsPanel.Hide();
        }
    }
}
