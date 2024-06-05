using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace K9rush
{
    public partial class MainMenu : Form
    {

        private List<PictureBox> characterPictureBoxes = new List<PictureBox>();
        private List<Label> characterLabels = new List<Label>();
        private int currentCharacterIndex = 0;
        private string selectedCharacter;



        public MainMenu()
        {
            InitializeComponent();
            ApplyButtonStyling();
            InitializeCharacterPictureBoxes();
            ShowCurrentCharacter();

            // Set the StartPosition property to Manual
            this.StartPosition = FormStartPosition.Manual;

            // Set the location of the form to (100, 100)
            this.Location = new Point(650, 150);

        }


        private void InitializeCharacterPictureBoxes()
        {
            //add picturebox controls representing characters to the list
            characterPictureBoxes.Add(pictureBoxChSelect1);
            characterPictureBoxes.Add(pictureBoxChSelect2);
            characterPictureBoxes.Add(pictureBoxChSelect3);
            characterPictureBoxes.Add(pictureBoxChSelect4);

            //add labels for the character names
            characterLabels.Add(labelDog1);
            characterLabels.Add(labelDog2);
            characterLabels.Add(labelDog3);
            characterLabels.Add(labelDog4);


            //hiding all the pictureboxes expect the first one
            for (int i = 1; i < characterPictureBoxes.Count; i++)
            {
                characterPictureBoxes[i].Visible = false;
                characterLabels[i].Visible = false;
            }


        }

        private void ShowCurrentCharacter()
        {
            //Hidding all pictureboxes
            foreach (PictureBox pictureBox in characterPictureBoxes)
            {
                pictureBox.Visible = false;
            }
            foreach (Label label in characterLabels)
            {
                label.Visible = false;
            }

            //show the picturebox matching the current character index
            characterPictureBoxes[currentCharacterIndex].Visible = true;
            characterLabels[currentCharacterIndex].Visible = true;
            selectedCharacter = characterLabels[currentCharacterIndex].Text; // Set the selected character
        }

        public string SelectedCharacter
        {
            get { return selectedCharacter; }
            set { selectedCharacter = value; }
        }


        private void ApplyButtonStyling()
        {
            // Create an oval GraphicsPath for the button's shape
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            buttonPath.AddEllipse(0, 0, PlayBtn.Width, PlayBtn.Height);
            PlayBtn.Region = new Region(buttonPath);
            HowToPlayBtn.Region = new Region(buttonPath);
            ExitBtn.Region = new Region(buttonPath);
        }


        private void PlayBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedCharacter))
            {
                MessageBox.Show($"Starting game with character: {selectedCharacter}");
                Game gameForm = new Game(selectedCharacter);
                gameForm.Show();
                this.Hide(); // Hide the main menu form if the game started successfully
            }
            else
            {
                MessageBox.Show("Please select a character first!", "Character Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HowToPlayBtn_Click(object sender, EventArgs e)
        {

            HowToPlay howToPlayForm = new HowToPlay();
            howToPlayForm.Show();


        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // Close the MainMenu form
            this.Close();

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            //hide the current pictureBox
            characterPictureBoxes[currentCharacterIndex].Visible = false;
            characterLabels[currentCharacterIndex].Visible = false;
            //increment the current character index
            currentCharacterIndex++;
            //go back to the first index character if the index exceeds the number of character
            if (currentCharacterIndex >= characterPictureBoxes.Count)
            {
                currentCharacterIndex = 0;

            }
            //show the character picturBox
            characterPictureBoxes[currentCharacterIndex].Visible = true;
            characterLabels[currentCharacterIndex].Visible = true;
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            //hide the current pictureBox
            characterPictureBoxes[currentCharacterIndex].Visible = false;
            characterLabels[currentCharacterIndex].Visible = false;
            //decrement the current character index
            currentCharacterIndex--;
            //go back to the last index character if the index exceeds the number of character
            if (currentCharacterIndex < 0)
            {
                currentCharacterIndex = characterPictureBoxes.Count - 1;
            }
            //show the character picturBox
            characterPictureBoxes[currentCharacterIndex].Visible = true;
            characterLabels[currentCharacterIndex].Visible = true;
        }

        public static bool Game(string selectedCharacter)
        {
            // Start the game with the selected character
            // Implement your game logic here

            // Return true if the game started successfully, false otherwise
            return true; // For example, you can always return true if there are no failure conditions
        }
        private void SaveCharacterBtn_Click(object sender, EventArgs e)
        {
            selectedCharacter = characterLabels[currentCharacterIndex].Text;
            MessageBox.Show($"Character {selectedCharacter} saved!", "Character Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBoxChSelect4_Click(object sender, EventArgs e)
        {

        }
    }
}
