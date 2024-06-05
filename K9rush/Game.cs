using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K9rush
{
    public partial class Game : Form
    {

        private List<PictureBox> platforms = new List<PictureBox>();
        private PictureBox pictureBoxCharacter;
        private string selectedCharacter;
        private System.Windows.Forms.Timer gameTimer;
        private bool isJumping = false;
        private int jumpSpeed = 0;
        private int force = 12;
        private int gravity = 12;
        private int characterSpeed = 10;
        private int score = 0;
        private bool isGameOver = false;
        private bool moveLeft = false;
        private bool moveRight = false;
        private Label scoreLabel;

        public Game(string character)
        {
            InitializeComponent();
            selectedCharacter = character;
            InitializeGameComponents();
        }
        private void UpdateScoreLabel()
        {
            scoreLabel.Text = "Score: " + score.ToString();
        }
        private void InitializeGameComponents()
        {
            // Ръчно задаване на изображението за фона
            pictureBoxBackground.Image = Image.FromFile("D:\\Yoana\\K9 rush\\sprites\\background2.png");
            pictureBoxBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBackground.Dock = DockStyle.Fill;
            Controls.Add(pictureBoxBackground);
            pictureBoxBackground.SendToBack();

            AddPlatforms();

            pictureBoxCharacter = new PictureBox
            {
                Location = new Point(platforms[0].Left, platforms[0].Top - Properties.Resources.jayp.Height),
                SizeMode = PictureBoxSizeMode.AutoSize,
                Image = GetCharacterImage(selectedCharacter),
               
            };
            
            Controls.Add(pictureBoxCharacter);
            pictureBoxCharacter.BringToFront();

            scoreLabel = new Label
            {
                Text = "Score: 0",
                ForeColor = Color.Black,
                BackColor = Color.LightGreen,
                Location = new Point(10, 10),
                Font = new Font("Arial", 14, FontStyle.Bold)
            };
            Controls.Add(scoreLabel);
            scoreLabel.BringToFront();

            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 20;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();

            this.KeyDown += new KeyEventHandler(Game_KeyDown);
            this.KeyUp += new KeyEventHandler(Game_KeyUp);
        }

      

        private Image GetCharacterImage(string character)
        {
            switch (character)
            {
                case "Jay":
                    return Properties.Resources.jayp; 
                case "Rocky":
                    return Properties.Resources.rockyp;
                case "Jill":
                    return Properties.Resources.jillp;
                case "Corgi":
                    return Properties.Resources.corgip;
                default:
                    return Properties.Resources.jayp; 
            }
        }

        private void AddPlatforms()
        {
            int startX = 50;
            int startY = 400;
            int platformWidth = 150;
            int platformHeight = 20;
            int gap = 150;

            for (int i = 0; i < 10; i++)
            {
                AddPlatform(new Point(startX, startY));
                startX += platformWidth + gap;
                startY = new Random().Next(200, 400);

            }
        }

        private void AddPlatform(Point location)
        {
            PictureBox platform = new PictureBox
            {
                Size = new Size(150, 20),
                Location = location,
                BackColor = Color.Brown,
                BackgroundImage = Properties.Resources.platform_tile_015,
                BackgroundImageLayout = ImageLayout.Stretch,
                Tag = "platform"
            };
            platforms.Add(platform);
            Controls.Add(platform);
            platform.BringToFront();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (isGameOver)
                return;

            ApplyGravity();
            MoveCharacter();
            MovePlatforms();
            CheckPlatformCollision();

            if (pictureBoxCharacter.Top + pictureBoxCharacter.Height > this.ClientSize.Height)
            {
                GameOver();
            }
        }

        private void ApplyGravity()
        {
            if (isJumping)
            {
                pictureBoxCharacter.Top -= jumpSpeed;
                jumpSpeed -= 1;

                if (jumpSpeed <= 0)
                {
                    isJumping = false;
                }
            }
            else
            {
                pictureBoxCharacter.Top += gravity;
            }
        }

        private void MoveCharacter()
        {
            if (moveLeft && pictureBoxCharacter.Left > 0)
            {
                pictureBoxCharacter.Left -= characterSpeed;
            }
            if (moveRight && pictureBoxCharacter.Left + pictureBoxCharacter.Width < this.ClientSize.Width)
            {
                pictureBoxCharacter.Left += characterSpeed;
            }

            if (pictureBoxCharacter.Left + pictureBoxCharacter.Width > this.ClientSize.Width - 200)
            {
                pictureBoxCharacter.Left = this.ClientSize.Width - 200 - pictureBoxCharacter.Width;
                MoveBackgroundAndPlatforms(-characterSpeed);
            }
            else if (pictureBoxCharacter.Left < 200)
            {
                pictureBoxCharacter.Left = 200;
                MoveBackgroundAndPlatforms(characterSpeed);
            }
        }

        private void MoveBackgroundAndPlatforms(int speed)
        {
            pictureBoxBackground.Left += speed;

            foreach (PictureBox platform in platforms)
            {
                platform.Left += speed;
            }
        }

        private void MovePlatforms()
        {
            foreach (PictureBox platform in platforms)
            {
                if (platform.Left + platform.Width < 0)
                {
                    platform.Left = this.ClientSize.Width + new Random().Next(200, 600);
                    platform.Top = new Random().Next(200, 400);
                    score++;
                    scoreLabel.Text = "Score: " + score.ToString();
                }
            }

            foreach (PictureBox platform in platforms)
            {
                if (platform.Left + platform.Width < 0)
                {
                    platform.Left = this.ClientSize.Width + new Random().Next(100, 200);
                    platform.Top = new Random().Next(200, 400);
                    score++; // Увеличаване на брояча
                    scoreLabel.Text = "Score: " + score.ToString(); // Актуализиране на текста на етикета с резултата
                }
            }
        }

        private void CheckPlatformCollision()
        {
            foreach (PictureBox platform in platforms)
            {
                if (pictureBoxCharacter.Bounds.IntersectsWith(platform.Bounds))
                {
                    if (pictureBoxCharacter.Bottom >= platform.Top && pictureBoxCharacter.Top < platform.Top)
                    {
                        pictureBoxCharacter.Top = platform.Top - pictureBoxCharacter.Height;
                        jumpSpeed = 0;
                        isJumping = false;
                    }
                }
            }
        }

        private void GameOver()
        {
            gameTimer.Stop();
            isGameOver = true;
            MessageBox.Show("Game Over! Score: " + score);
            this.Close();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !isJumping)
            {
                isJumping = true;
                jumpSpeed = force;
            }
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                isJumping = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
        }
    }
}

