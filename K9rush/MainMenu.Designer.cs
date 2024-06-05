namespace K9rush
{
    partial class MainMenu
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
            PlayBtn = new Button();
            HowToPlayBtn = new Button();
            ExitBtn = new Button();
            pictureBoxChSelect1 = new PictureBox();
            NextBtn = new Button();
            PreviousBtn = new Button();
            pictureBoxChSelect2 = new PictureBox();
            pictureBoxChSelect3 = new PictureBox();
            pictureBoxChSelect4 = new PictureBox();
            labelDog1 = new Label();
            labelDog2 = new Label();
            labelDog3 = new Label();
            labelDog4 = new Label();
            SaveCharacterBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChSelect1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChSelect2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChSelect3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChSelect4).BeginInit();
            SuspendLayout();
            // 
            // PlayBtn
            // 
            PlayBtn.BackColor = Color.FromArgb(255, 128, 255);
            PlayBtn.Cursor = Cursors.Hand;
            PlayBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            PlayBtn.FlatAppearance.BorderSize = 100;
            PlayBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            PlayBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
            PlayBtn.FlatStyle = FlatStyle.Popup;
            PlayBtn.Font = new Font("Sitka Banner", 19.8000011F, FontStyle.Bold);
            PlayBtn.ForeColor = SystemColors.ActiveCaptionText;
            PlayBtn.Location = new Point(176, 437);
            PlayBtn.Name = "PlayBtn";
            PlayBtn.Size = new Size(292, 92);
            PlayBtn.TabIndex = 0;
            PlayBtn.Text = "Play";
            PlayBtn.UseVisualStyleBackColor = false;
            PlayBtn.Click += PlayBtn_Click;
            // 
            // HowToPlayBtn
            // 
            HowToPlayBtn.BackColor = Color.FromArgb(192, 192, 255);
            HowToPlayBtn.Cursor = Cursors.Help;
            HowToPlayBtn.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 255);
            HowToPlayBtn.FlatAppearance.BorderSize = 100;
            HowToPlayBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            HowToPlayBtn.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            HowToPlayBtn.FlatStyle = FlatStyle.Popup;
            HowToPlayBtn.Font = new Font("Sitka Banner", 19.8000011F, FontStyle.Bold);
            HowToPlayBtn.Location = new Point(176, 552);
            HowToPlayBtn.Name = "HowToPlayBtn";
            HowToPlayBtn.Size = new Size(292, 92);
            HowToPlayBtn.TabIndex = 1;
            HowToPlayBtn.Text = "How to play?";
            HowToPlayBtn.UseVisualStyleBackColor = false;
            HowToPlayBtn.Click += HowToPlayBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.LightCoral;
            ExitBtn.Cursor = Cursors.Hand;
            ExitBtn.FlatAppearance.BorderColor = Color.Red;
            ExitBtn.FlatAppearance.BorderSize = 100;
            ExitBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            ExitBtn.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            ExitBtn.Font = new Font("Sitka Banner", 19.8000011F, FontStyle.Bold);
            ExitBtn.Location = new Point(514, 647);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(140, 62);
            ExitBtn.TabIndex = 2;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // pictureBoxChSelect1
            // 
            pictureBoxChSelect1.Image = Properties.Resources.jayp;
            pictureBoxChSelect1.Location = new Point(176, 77);
            pictureBoxChSelect1.Name = "pictureBoxChSelect1";
            pictureBoxChSelect1.Size = new Size(292, 224);
            pictureBoxChSelect1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxChSelect1.TabIndex = 3;
            pictureBoxChSelect1.TabStop = false;
            pictureBoxChSelect1.Visible = false;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.Plum;
            NextBtn.Font = new Font("Showcard Gothic", 19.8000011F);
            NextBtn.ForeColor = Color.Sienna;
            NextBtn.Location = new Point(463, 157);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(35, 59);
            NextBtn.TabIndex = 4;
            NextBtn.Text = ">";
            NextBtn.UseVisualStyleBackColor = false;
            NextBtn.Click += NextBtn_Click;
            // 
            // PreviousBtn
            // 
            PreviousBtn.BackColor = Color.Plum;
            PreviousBtn.Font = new Font("Showcard Gothic", 19.8000011F);
            PreviousBtn.ForeColor = Color.Sienna;
            PreviousBtn.Location = new Point(144, 157);
            PreviousBtn.Name = "PreviousBtn";
            PreviousBtn.Size = new Size(36, 59);
            PreviousBtn.TabIndex = 5;
            PreviousBtn.Text = "<";
            PreviousBtn.UseVisualStyleBackColor = false;
            PreviousBtn.Click += PreviousBtn_Click;
            // 
            // pictureBoxChSelect2
            // 
            pictureBoxChSelect2.Image = Properties.Resources.rockyp;
            pictureBoxChSelect2.Location = new Point(176, 77);
            pictureBoxChSelect2.Name = "pictureBoxChSelect2";
            pictureBoxChSelect2.Size = new Size(292, 224);
            pictureBoxChSelect2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxChSelect2.TabIndex = 6;
            pictureBoxChSelect2.TabStop = false;
            pictureBoxChSelect2.Visible = false;
            // 
            // pictureBoxChSelect3
            // 
            pictureBoxChSelect3.Image = Properties.Resources.jillp;
            pictureBoxChSelect3.Location = new Point(176, 77);
            pictureBoxChSelect3.Name = "pictureBoxChSelect3";
            pictureBoxChSelect3.Size = new Size(292, 224);
            pictureBoxChSelect3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxChSelect3.TabIndex = 7;
            pictureBoxChSelect3.TabStop = false;
            pictureBoxChSelect3.Visible = false;
            // 
            // pictureBoxChSelect4
            // 
            pictureBoxChSelect4.Image = Properties.Resources.corgip;
            pictureBoxChSelect4.Location = new Point(176, 77);
            pictureBoxChSelect4.Name = "pictureBoxChSelect4";
            pictureBoxChSelect4.Size = new Size(292, 224);
            pictureBoxChSelect4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxChSelect4.TabIndex = 8;
            pictureBoxChSelect4.TabStop = false;
            pictureBoxChSelect4.Visible = false;
            pictureBoxChSelect4.Click += pictureBoxChSelect4_Click;
            // 
            // labelDog1
            // 
            labelDog1.AutoSize = true;
            labelDog1.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold);
            labelDog1.Location = new Point(302, 25);
            labelDog1.Name = "labelDog1";
            labelDog1.Size = new Size(54, 36);
            labelDog1.TabIndex = 9;
            labelDog1.Text = "Jay";
            labelDog1.Visible = false;
            // 
            // labelDog2
            // 
            labelDog2.AutoSize = true;
            labelDog2.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold);
            labelDog2.Location = new Point(287, 25);
            labelDog2.Name = "labelDog2";
            labelDog2.Size = new Size(94, 36);
            labelDog2.TabIndex = 10;
            labelDog2.Text = "Rocky";
            labelDog2.Visible = false;
            // 
            // labelDog3
            // 
            labelDog3.AutoSize = true;
            labelDog3.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold);
            labelDog3.Location = new Point(304, 25);
            labelDog3.Name = "labelDog3";
            labelDog3.Size = new Size(52, 36);
            labelDog3.TabIndex = 11;
            labelDog3.Text = "Jill";
            labelDog3.Visible = false;
            // 
            // labelDog4
            // 
            labelDog4.AutoSize = true;
            labelDog4.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold);
            labelDog4.Location = new Point(287, 25);
            labelDog4.Name = "labelDog4";
            labelDog4.Size = new Size(84, 36);
            labelDog4.TabIndex = 12;
            labelDog4.Text = "Corgi";
            labelDog4.Visible = false;
            // 
            // SaveCharacterBtn
            // 
            SaveCharacterBtn.BackColor = Color.MediumSpringGreen;
            SaveCharacterBtn.Cursor = Cursors.Hand;
            SaveCharacterBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            SaveCharacterBtn.FlatAppearance.BorderSize = 100;
            SaveCharacterBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            SaveCharacterBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 192);
            SaveCharacterBtn.FlatStyle = FlatStyle.Popup;
            SaveCharacterBtn.Font = new Font("Sitka Banner", 19.8000011F, FontStyle.Bold);
            SaveCharacterBtn.ForeColor = SystemColors.ActiveCaptionText;
            SaveCharacterBtn.Location = new Point(267, 307);
            SaveCharacterBtn.Name = "SaveCharacterBtn";
            SaveCharacterBtn.Size = new Size(104, 61);
            SaveCharacterBtn.TabIndex = 13;
            SaveCharacterBtn.Text = "Pick";
            SaveCharacterBtn.UseVisualStyleBackColor = false;
            SaveCharacterBtn.Click += SaveCharacterBtn_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(641, 705);
            Controls.Add(SaveCharacterBtn);
            Controls.Add(labelDog4);
            Controls.Add(labelDog3);
            Controls.Add(labelDog2);
            Controls.Add(labelDog1);
            Controls.Add(pictureBoxChSelect4);
            Controls.Add(pictureBoxChSelect3);
            Controls.Add(pictureBoxChSelect2);
            Controls.Add(PreviousBtn);
            Controls.Add(NextBtn);
            Controls.Add(pictureBoxChSelect1);
            Controls.Add(ExitBtn);
            Controls.Add(HowToPlayBtn);
            Controls.Add(PlayBtn);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(2000, 100);
            Name = "MainMenu";
            Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBoxChSelect1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChSelect2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChSelect3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChSelect4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button HowToPlayBtn;
        private Button ExitBtn;
        public Button PlayBtn;
        private PictureBox pictureBoxChSelect2;
        private PictureBox pictureBoxChSelect1;
        private Button NextBtn;
        private Button PreviousBtn;
        private PictureBox pictureBoxChSelect3;
        private PictureBox pictureBoxChSelect4;
        private Label labelDog1;
        private Label labelDog2;
        private Label labelDog3;
        private Label labelDog4;
        public Button SaveCharacterBtn;
    }
}
