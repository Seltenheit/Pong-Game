namespace Po_n_g
{
    partial class POnG
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POnG));
            this.Background = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.SettingsCloseButton = new System.Windows.Forms.Label();
            this.SettingsText2 = new System.Windows.Forms.Label();
            this.SettingsText1 = new System.Windows.Forms.Label();
            this.MenuBox = new System.Windows.Forms.Panel();
            this.NewGameButton = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Label();
            this.ResumeButton = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Label();
            this.GameOver = new System.Windows.Forms.Label();
            this.OnPause = new System.Windows.Forms.Label();
            this.PauseButton = new System.Windows.Forms.Label();
            this.MenuButton = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.GamePanel = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Background.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.MenuBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Controls.Add(this.SettingsPanel);
            this.Background.Controls.Add(this.MenuBox);
            this.Background.Controls.Add(this.RestartButton);
            this.Background.Controls.Add(this.GameOver);
            this.Background.Controls.Add(this.OnPause);
            this.Background.Controls.Add(this.PauseButton);
            this.Background.Controls.Add(this.MenuButton);
            this.Background.Controls.Add(this.Result);
            this.Background.Controls.Add(this.Ball);
            this.Background.Controls.Add(this.GamePanel);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(878, 542);
            this.Background.TabIndex = 0;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SettingsPanel.Controls.Add(this.SettingsCloseButton);
            this.SettingsPanel.Controls.Add(this.SettingsText2);
            this.SettingsPanel.Controls.Add(this.SettingsText1);
            this.SettingsPanel.Location = new System.Drawing.Point(213, 34);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(208, 134);
            this.SettingsPanel.TabIndex = 13;
            // 
            // SettingsCloseButton
            // 
            this.SettingsCloseButton.AutoSize = true;
            this.SettingsCloseButton.BackColor = System.Drawing.Color.IndianRed;
            this.SettingsCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsCloseButton.Location = new System.Drawing.Point(194, 0);
            this.SettingsCloseButton.Name = "SettingsCloseButton";
            this.SettingsCloseButton.Size = new System.Drawing.Size(14, 17);
            this.SettingsCloseButton.TabIndex = 0;
            this.SettingsCloseButton.Text = "x";
            this.SettingsCloseButton.Click += new System.EventHandler(this.SettingsCloseButton_Click);
            // 
            // SettingsText2
            // 
            this.SettingsText2.AutoSize = true;
            this.SettingsText2.Location = new System.Drawing.Point(23, 71);
            this.SettingsText2.Name = "SettingsText2";
            this.SettingsText2.Size = new System.Drawing.Size(177, 17);
            this.SettingsText2.TabIndex = 1;
            this.SettingsText2.Text = "I`m not having sex with you";
            // 
            // SettingsText1
            // 
            this.SettingsText1.AutoSize = true;
            this.SettingsText1.Location = new System.Drawing.Point(25, 51);
            this.SettingsText1.Name = "SettingsText1";
            this.SettingsText1.Size = new System.Drawing.Size(175, 17);
            this.SettingsText1.TabIndex = 0;
            this.SettingsText1.Text = "Put your dick away, Walter";
            // 
            // MenuBox
            // 
            this.MenuBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.MenuBox.Controls.Add(this.NewGameButton);
            this.MenuBox.Controls.Add(this.SettingsButton);
            this.MenuBox.Controls.Add(this.ExitButton);
            this.MenuBox.Controls.Add(this.ResumeButton);
            this.MenuBox.Location = new System.Drawing.Point(268, 143);
            this.MenuBox.Name = "MenuBox";
            this.MenuBox.Size = new System.Drawing.Size(334, 208);
            this.MenuBox.TabIndex = 10;
            // 
            // NewGameButton
            // 
            this.NewGameButton.AutoSize = true;
            this.NewGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewGameButton.Location = new System.Drawing.Point(58, 68);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(77, 17);
            this.NewGameButton.TabIndex = 12;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.AutoSize = true;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.Location = new System.Drawing.Point(58, 105);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(59, 17);
            this.SettingsButton.TabIndex = 11;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Location = new System.Drawing.Point(58, 141);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 17);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ExitButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseClick);
            // 
            // ResumeButton
            // 
            this.ResumeButton.AutoSize = true;
            this.ResumeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResumeButton.Location = new System.Drawing.Point(58, 34);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(60, 17);
            this.ResumeButton.TabIndex = 9;
            this.ResumeButton.Text = "Resume";
            this.ResumeButton.Click += new System.EventHandler(this.ResumeButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.AutoSize = true;
            this.RestartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestartButton.Location = new System.Drawing.Point(378, 326);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(116, 25);
            this.RestartButton.TabIndex = 7;
            this.RestartButton.Text = "Restart (R)";
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // GameOver
            // 
            this.GameOver.AutoSize = true;
            this.GameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameOver.Location = new System.Drawing.Point(145, 228);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(573, 73);
            this.GameOver.TabIndex = 6;
            this.GameOver.Text = "G A M E    O V E R";
            // 
            // OnPause
            // 
            this.OnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OnPause.AutoSize = true;
            this.OnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OnPause.Location = new System.Drawing.Point(0, 0);
            this.OnPause.Margin = new System.Windows.Forms.Padding(0);
            this.OnPause.Name = "OnPause";
            this.OnPause.Size = new System.Drawing.Size(126, 31);
            this.OnPause.TabIndex = 5;
            this.OnPause.Text = "PAUSED";
            // 
            // PauseButton
            // 
            this.PauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PauseButton.AutoSize = true;
            this.PauseButton.Location = new System.Drawing.Point(765, 0);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(71, 17);
            this.PauseButton.TabIndex = 4;
            this.PauseButton.Text = "Pause (P)";
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            this.PauseButton.MouseEnter += new System.EventHandler(this.PauseButton_MouseEnter);
            this.PauseButton.MouseLeave += new System.EventHandler(this.PauseButton_MouseLeave);
            // 
            // MenuButton
            // 
            this.MenuButton.AutoSize = true;
            this.MenuButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.MenuButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuButton.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuButton.Image")));
            this.MenuButton.Location = new System.Drawing.Point(857, 0);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(21, 31);
            this.MenuButton.TabIndex = 3;
            this.MenuButton.Text = " ";
            this.MenuButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseClick);
            this.MenuButton.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.MenuButton.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Montserrat", 10.45F);
            this.Result.Location = new System.Drawing.Point(796, 37);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(69, 20);
            this.Result.TabIndex = 2;
            this.Result.Text = "Result: 0";
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.SystemColors.Highlight;
            this.Ball.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Ball.ErrorImage")));
            this.Ball.InitialImage = ((System.Drawing.Image)(resources.GetObject("Ball.InitialImage")));
            this.Ball.Location = new System.Drawing.Point(194, 144);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(50, 50);
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.SystemColors.Desktop;
            this.GamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GamePanel.Location = new System.Drawing.Point(318, 494);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(170, 24);
            this.GamePanel.TabIndex = 0;
            this.GamePanel.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // POnG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 542);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "POnG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Background.ResumeLayout(false);
            this.Background.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.MenuBox.ResumeLayout(false);
            this.MenuBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamePanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox GamePanel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label MenuButton;
        private System.Windows.Forms.Label PauseButton;
        private System.Windows.Forms.Label OnPause;
        private System.Windows.Forms.Label GameOver;
        private System.Windows.Forms.Label RestartButton;
        private System.Windows.Forms.Panel MenuBox;
        private System.Windows.Forms.Label ResumeButton;
        private System.Windows.Forms.Label SettingsButton;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label NewGameButton;
        private System.Windows.Forms.Label SettingsCloseButton;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Label SettingsText2;
        private System.Windows.Forms.Label SettingsText1;
    }
}

