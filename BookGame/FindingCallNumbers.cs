using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BookGame
{
    public partial class FindingCallNumbers : Form
    {

        /// <summary>
        /// quiz game variable
        /// </summary>
        // Define a class to represent a Dewey Decimal entry
        public class DeweyEntry
        {
            public string Class { get; set; }
            public string Caption { get; set; }
            public int Level { get; set; }
        }

        private List<DeweyEntry> deweyEntries;
        private Random random = new Random();
        private TreeNode root;
        private TreeNode currentNode;
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        int timeremaining = 60;
        int scoring = 0;
        int totalScore;
        // this will allow the media player to play the song
        //this snip cam from YouTube
        //the channel is Dew Clarke
        // video link: https://youtu.be/6AVghOqSYUs?si=wnocx35hZGQ7cXRs
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        WindowsMediaPlayer player2 = new WindowsMediaPlayer();
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Starts the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayBT_Click(object sender, EventArgs e)
        {

            // Hide the Play button
            PlayBT.Visible = false;

            // Make the question label and option buttons visible
            lblQuestion.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

            // Start the timer
            TimeTicker.Start();

            // Ask the first question
            askQuestion(questionNumber);
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        public FindingCallNumbers()
        {
            InitializeComponent();

            // Load Dewey Decimal entries from the text file
            LoadDeweyEntries();

            totalQuestions = 3; // or set it based on the number of entries in your text file

            // Initially hide the question label and option buttons
            lblQuestion.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            // Set up the Play button click event
            PlayBT.Click += PlayBT_Click;

            askQuestion(questionNumber);

            CallTimerLB.Text = $"Time: {timeremaining}";
            ScoringLB.Text = $"PB: {totalScore}";
            player2.URL = "y2mate.com - 5 Minute timer LoFi relaxing Chillhop background music.mp3";

        }

        /// <summary>
        /// Plays audio sound for when the user gets and answer wrong
        /// </summary>
        private void PlayBuzzSound()
        {
            //this are the media players that will play the music in the game
            // this will allow the media player to play the song
            //this snip cam from YouTube
            //the channel is Dew Clarke
            // video link: https://youtu.be/6AVghOqSYUs?si=wnocx35hZGQ7cXRs
            player.URL = "y2mate.com - EXTREMELY LOUD INCORRECT BUZZER SOUND.mp3";
            
        }
 //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Checks for the answer and adds to the score and percentage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var sendObject = (Button)sender;
            int buttonTag = Convert.ToInt32(sendObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
                scoring++;
            }
            else
            {
                PlayBuzzSound();
            }

            //work out the total
            totalScore = (int)Math.Round((double)scoring * 100);
            //Update the score label
            ScoringLB.Text = $"PB: {totalScore}";
            if (questionNumber == totalQuestions)
            {
                TimeTicker.Stop();
                //work out the percentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                //work out the total
                totalScore =(int)Math.Round((double)score *100);

                //inform the user of the score and game is over.
                MessageBox.Show("Quiz Ended " + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click ok to play Again");

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
                //timer event reset
                timeremaining = 60;
                CallTimerLB.Text = $"Time: {timeremaining}";
                scoring= 0;
                ScoringLB.Text = $"PB: {totalScore}";

            }
            questionNumber++;
            askQuestion(questionNumber);
            
            //will restart the timer
            TimeTicker.Start();
        }
 //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// loads the game
        /// </summary>
        private void LoadDeweyEntries()
        {
            deweyEntries = new List<DeweyEntry>();

            // Get the path to the Debug folder
            string debugFolderPath = AppDomain.CurrentDomain.BaseDirectory;

            // Combine the path to the Debug folder with the file name
            string filePath = Path.Combine(debugFolderPath, "DeweyDecialValue.txt");

            // Read the text file and parse each line into DeweyEntry objects
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                for (int i = 1; i < lines.Length; i++) // Start from index 1 to skip the header
                {
                    string line = lines[i];
                    string[] parts = line.Split(';');

                    if (parts.Length == 3)
                    {
                        string classString = parts[0];
                        string caption = parts[1];
                        string levelString = parts[2];

                        // Validate and parse the class and level
                        if (int.TryParse(classString, out int classNumber) && int.TryParse(levelString, out int level))
                        {
                            DeweyEntry entry = new DeweyEntry
                            {
                                Class = classString,
                                Caption = caption,
                                Level = level
                            };

                            deweyEntries.Add(entry);
                        }
                        
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading the file: " + ex.Message);
            }

            root = TreeNode.BuildTree(deweyEntries);
            currentNode = root;
        }

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Choose 4 random options to make the levels difficult
        /// </summary>
        /// <param name="correctEntry"></param>
        /// <returns></returns>
        private List<DeweyEntry> GetRandomOptions(DeweyEntry correctEntry)
        {
            List<DeweyEntry> options = new List<DeweyEntry> { correctEntry };

            int currentClass = correctEntry.Level;

            // Define a broader range of classes (adjust as needed)
            int classRangeStart = Math.Max(000, currentClass - 200);
            int classRangeEnd = Math.Min(999, currentClass + 200);

            // Add other random options from the defined class range
            while (options.Count < 4)
            {
                int targetClass = random.Next(classRangeStart, classRangeEnd + 1);

                // Get a random entry from the tree with the target class
                DeweyEntry randomOption = TreeNode.GetRandomEntryFromTree(root, random, targetClass)?.Entry;

                // Make sure the random option is not the correct one and is of a different level
                if (randomOption != null && !options.Contains(randomOption) && randomOption.Level != currentClass)
                {
                    options.Add(randomOption);
                }
            }

            // Shuffle the list of options
            options = options.OrderBy(_ => random.Next()).ToList();

            return options;
        }
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Picks the value to use as question
        /// </summary>
        /// <param name="qnum"></param>
        private void askQuestion(int qnum)
        {
            if (qnum <= totalQuestions)
            {
                // Traverse the tree to get a random Dewey Decimal entry for the question
                currentNode = TreeNode.GetRandomNode(root, random);

                // Set the question text
                lblQuestion.Text = $"{currentNode.Entry.Class}-{currentNode.Entry.Caption}?";

                // Create a list of options, including the correct one
                List<DeweyEntry> options = GetRandomOptions(currentNode.Entry);

                // Set the text for the buttons based on the shuffled options
                button1.Text = $"{options[0].Class} - {options[0].Caption}";
                button2.Text = $"{options[1].Class} - {options[1].Caption}";
                button3.Text = $"{options[2].Class} - {options[2].Caption}";
                button4.Text = $"{options[3].Class} - {options[3].Caption}";

                // Set the correct answer based on the position of the correct option
                correctAnswer = options.IndexOf(currentNode.Entry) + 1;
            }
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Time ticker for timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeTicker_Tick(object sender, EventArgs e)
        {

            //time even clicker was taken an adapted from Youtube
            //the Youtube channel is LearnStuffz
            //Youtube link to video: https://www.youtube.com/watch?v=OXz3Ei1xrZ0
            // Update the remaining time and the displayed time on your form
            timeremaining--;
            CallTimerLB.Text = $"Time: {timeremaining}";

            // Check if the timer has reached zero
            if (timeremaining == 0)
            {
                // Stop the timer
                TimeTicker.Stop();

                // Display a message box indicating that the user has lost
                MessageBox.Show("Time's up! You lost.", "Game Over");

                // Reset game state
                ResetGameState();
            }
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
       
        /// <summary>
        /// To reset the game when the timer is 0
        /// </summary>
        private void ResetGameState()
        {
            // Hide the question label and option buttons
            lblQuestion.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            // Make the Play button visible
            PlayBT.Visible = true;

            // Reset game variables
            score = 0;
            questionNumber = 0;
            timeremaining = 60;
            scoring = 0;
            totalScore = 0;

            // Update the labels
            CallTimerLB.Text = $"Time: {timeremaining}";
            ScoringLB.Text = $"PB: {totalScore}";
        }

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Button to exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitBt_Click(object sender, EventArgs e)
        {

            // Display a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to go back to the Home page? ", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            // Check the user's choice
            if (result == DialogResult.OK)
            {
                //this method was modified by YouTube
                //the channel is Code Conclusion
                //link to video: https://youtu.be/6AVghOqSYUs?si=spFgskdkpnS5H3Cd
                Form1 form1 = new Form1();
                form1.Show();
                Visible = false;
                //stops the background music being played
                player2.controls.stop();

                //stop the timer when you leave the game
                TimeTicker.Stop();
            }
            
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
         /// <summary>
         /// About button to show how the application works
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void AboutBT_Click(object sender, EventArgs e)
        {

            //inform the user on how to .
            MessageBox.Show("About Quiz " + Environment.NewLine +
                "----------------------------------------------------------------------"+ Environment.NewLine +
                "You need to choose the correct answer for the question " + Environment.NewLine +
                "Here is an exampl: " + Environment.NewLine +
                "For each question, randomly select a third level entry from the data, for example," +
                "\r\n752 Color." +
                "\r\nDisplay four top level options to the user to choose between, one of which must be " +
                "\r\nthe correct one and the other three randomly selected incorrect answers" +
                "\r\n000 General" +
                "\r\n400 Language" +
                "\r\n700 Arts & Recreation (Correct answer)" +
                "\r\n800 Literature " + Environment.NewLine +
                "Click the ok button to proceed to the Quiz and have fun. ");
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Exit button to close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseBT_Click(object sender, EventArgs e)
        {
            // Display a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to exit? All progress will be lost.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            // Check the user's choice
            if (result == DialogResult.OK)
            {
                // User clicked OK, close the application
                Application.Exit();
            }
            // If DialogResult is Cancel, do nothing (close the message box)
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Background Music
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindingCallNumbers_Load(object sender, EventArgs e)
        {
            //play background music
            player2.controls.play();

            //disable the maximize feature
            MaximizeBox = false;
        }
    }

}
//------------------------------------------------------------ End of code ---------------------------------------------------------------------------------------------------------------------//
