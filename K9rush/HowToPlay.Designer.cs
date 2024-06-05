namespace K9rush
{
    partial class HowToPlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BackBtn = new Button();
            labelHowTo = new Label();
            labelExplain = new Label();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.LemonChiffon;
            BackBtn.Font = new Font("Sitka Banner", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BackBtn.Location = new Point(178, 581);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(192, 45);
            BackBtn.TabIndex = 0;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // labelHowTo
            // 
            labelHowTo.AutoSize = true;
            labelHowTo.Font = new Font("Sylfaen", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelHowTo.Location = new Point(178, 9);
            labelHowTo.Name = "labelHowTo";
            labelHowTo.Size = new Size(220, 44);
            labelHowTo.TabIndex = 1;
            labelHowTo.Text = "How to play?";
            // 
            // labelExplain
            // 
            labelExplain.AutoSize = true;
            labelExplain.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelExplain.Location = new Point(58, 74);
            labelExplain.Name = "labelExplain";
            labelExplain.Size = new Size(461, 158);
            labelExplain.TabIndex = 2;
            labelExplain.Text = "trtqrtfuq2ytf3uythrfq2ui34rtfu34qtybhtyq\r\n54oi34wqtfqtret4t\r\nerfqerfqjkerhfbhqwerfhbq4rfyhweb\r\n\r\nhfk nwefgvburbghkaerfgbvaekrfgbvaer\r\n";
            labelExplain.UseCompatibleTextRendering = true;
            // 
            // HowToPlay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(575, 625);
            Controls.Add(labelExplain);
            Controls.Add(labelHowTo);
            Controls.Add(BackBtn);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(100, 200);
            Name = "HowToPlay";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HowToPlay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn;
        private Label labelHowTo;
        private Label labelExplain;
    }
}