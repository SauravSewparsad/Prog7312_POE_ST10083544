//Prog POE Part2
//ST10083544
//Saurav Sewparsad
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//This is for the music player
using WMPLib;

namespace BookGame
{
    public partial class ColumnMatch : Form
    {
        //The dictionary thaat will store the call numbers and its description
        //this was found in stackoverflow by Joséph Flames : https://stackoverflow.com/users/17358811/joséph-flames
        //stackoverflow link: https://stackoverflow.com/questions/69886562/c-sharp-how-to-match-items-from-two-list-boxes
        Dictionary<string, string> callNumbers = new Dictionary<string, string>
        {
            { "100", "Philosophy and Psychology" },
            { "200", "Religion" },
            { "300", "Social Sciences" },
            { "400", "Language" },
            { "500", "Natural Sciences and Mathematics" },
            { "600", "Technology" },
            { "700", "Arts and Recreation" },
            { "800", "Literature" },
            { "900", "History and Geography" }
        };

        /// <summary>
        /// this is the  variablbes declared
        /// </summary>
        
        List<string> shuffledCallNumbers;
        Dictionary<string, string> userSelections;
        int remainingTime = 30;
        int score = 0;

        // this will allow the media player to play the song
        //this snip cam from YouTube
        //the channel is Dew Clarke
        // video link: https://youtu.be/6AVghOqSYUs?si=wnocx35hZGQ7cXRs
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        WindowsMediaPlayer player2 = new WindowsMediaPlayer();
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
/// <summary>
/// this will compile and run all the functions from the application
/// </summary>
        public ColumnMatch()
        {
            InitializeComponent();
            //this are the media players that will play the music in the game
            // this will allow the media player to play the song
            //this snip cam from YouTube
            //the channel is Dew Clarke
            // video link: https://youtu.be/6AVghOqSYUs?si=wnocx35hZGQ7cXRs
            player.URL = "y2mate.com - Sad trombone Sound effect.mp3";
            player2.URL = "y2mate.com - 5 MINUTES OF No Copyright Music CHILL LOFI HIP HOP BEAT Royalty free.mp3";
            
            //this will shuffle the call numbers and descriptions
            shuffledCallNumbers = new List<string>(callNumbers.Keys);
            userSelections = new Dictionary<string, string>();
            TimerLB.Text = $"Time remaining:{remainingTime} ";
            ScoreLB.Text = $"Score: {score}";
            LoadGame();
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// This is the load method that will take care of loading the game functions
        /// </summary>
        private void LoadGame()
        {
            //this will clear the boxes of any duplicates
            CallNumbersListBox.Items.Clear();
            DescriptionListBox.Items.Clear();
            userSelections.Clear();

            // Shuffle the call numbers
            shuffledCallNumbers.Shuffle();

            // Select four call numbers
            for (int i = 0; i < 4; i++)
            {
                string selectedCallNumber = shuffledCallNumbers[i];
                CallNumbersListBox.Items.Add(selectedCallNumber);
            }

            // Shuffle the descriptions
            List<string> descriptions = callNumbers.Values.ToList();
            descriptions.Shuffle();

            // Select the first four descriptions as correct answers
            List<string> correctDescriptions = descriptions.Take(4).ToList();

            // Select three more random descriptions as incorrect answers
            List<string> incorrectDescriptions = descriptions.Except(correctDescriptions).ToList();
            incorrectDescriptions.Shuffle();
            incorrectDescriptions = incorrectDescriptions.Take(3).ToList();

            // Combine correct and incorrect descriptions and shuffle them
            List<string> combinedDescriptions = correctDescriptions.Concat(incorrectDescriptions).ToList();
            combinedDescriptions.Shuffle();

            DescriptionListBox.Items.AddRange(combinedDescriptions.ToArray());
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
/// <summary>
/// this will handle the users selection in the listbox on the left of the application
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void CallNumbersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CallNumbersListBox.SelectedIndex >= 0)
            {
                string selectedCallNumber = CallNumbersListBox.SelectedItem.ToString();
                userSelections[selectedCallNumber] = null;
            }
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
/// <summary>
/// This will handle the users selection in the listBox on the right of the application
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void DescriptionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CallNumbersListBox.SelectedIndex >= 0 && DescriptionListBox.SelectedIndex >= 0)
            {
                string selectedCallNumber = CallNumbersListBox.SelectedItem.ToString();
                string selectedDescription = DescriptionListBox.SelectedItem.ToString();
                userSelections[selectedCallNumber] = selectedDescription;
            }
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
/// <summary>
/// This is the check function. When the user clicks the check button it will give them the score of the game
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void CheckBT_Click(object sender, EventArgs e)
        {
            //stop the game timer
            gameTimer.Stop();

            //check the users answer
            int correctCount = 0;
            int totalMatches = 4;

            for (int i = 0; i < 4; i++)
            {
                string selectedCallNumber = CallNumbersListBox.Items[i].ToString();
                string userSelectedDescription = userSelections[selectedCallNumber];

                if (callNumbers.ContainsKey(selectedCallNumber) && callNumbers[selectedCallNumber] == userSelectedDescription)
                    correctCount++;
                score++; // Increment the score
                ScoreLB.Text = $"Score: {score}"; // Update the score label
            }

            //this will display the score when the user presses the check button.
            int wrongCount = totalMatches - correctCount;
            MessageBox.Show($"Correct: {correctCount}, Wrong: {wrongCount}", "Results");
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
/// <summary>
/// this is the timer event handler. It will control the timer
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //time even clicker was taken an adapted from Youtube
            //the Youtube channel is LearnStuffz
            //Youtube link to video: https://www.youtube.com/watch?v=OXz3Ei1xrZ0
            // Update the remaining time and the displayed time on your form
            remainingTime--;
            TimerLB.Text = $"Time remaining: {remainingTime}";

            // Check if the timer has reached zero
            if (remainingTime == 0)
            {
                // Stop the timer
                gameTimer.Stop();
                player.controls.play();
                player2.controls.stop();

                // Display a message box indicating that the user has lost
                MessageBox.Show("Time's up! You lost.", "Game Over");

                //this will disable the check button when the game is over
                CheckBT.Enabled = false;

                //this will reset the user score to zero
                score = 0;
                ScoreLB.Text = $"Score: {score}";
            }
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
/// <summary>
/// This will restart the game everytime the button is clicked and reshuffle the call numbers and descriptions.
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void ResetBT_Click(object sender, EventArgs e)
        {
            //timer event reset
            remainingTime = 30;
            TimerLB.Text = $"Time remaining: {remainingTime}";

            //this will enable the check button
            CheckBT.Enabled = true;

            //will restart the timer
            gameTimer.Start();

            //play the background music
            player2.controls.play();

            //reload the game functions
            LoadGame();
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
/// <summary>
/// This will take the user back to the home page and allow them to choose another game
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void BackBT_Click(object sender, EventArgs e)
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
            gameTimer.Stop();
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
/// <summary>
/// This will play the background music in the application
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void ColumnMatch_Load(object sender, EventArgs e)
        {
            //play the background music
            player2.controls.play();

            //disable the maximize feature
            MaximizeBox = false;

        }
    }
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
    /// <summary>
    /// This is the shuffle extension that will shuffle the dictionary
    /// </summary>
    public static class ListExtensions
    {
        public static void Shuffle<T>(this List<T> list)
        {
            int n = list.Count;
            Random random = new Random();
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
//------------------------------------------------------------ End of code ---------------------------------------------------------------------------------------------------------------------//