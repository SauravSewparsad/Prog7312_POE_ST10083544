using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WMPLib;

namespace BookGame
{
    public partial class BookSorting : Form
    {
        // this will allow the media player to play the song
        //this snip cam from YouTube
        //the channel is Dew Clarke
        // video link: https://youtu.be/6AVghOqSYUs?si=wnocx35hZGQ7cXRs
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        //this is the book list
        private List<Book> books = new List<Book>();

        // Declare a variable to keep track of the correct order.
        private List<Book> correctOrder = new List<Book>();
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        public BookSorting()
        {
            InitializeComponent();
            player.URL = "y2mate.com - AdhesiveWombat  Night Shade  NO COPYRIGHT 8bit Music.mp3";


        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
  /// <summary>
  /// This the form load to exicute the commands
  /// </summary>
  /// <param name="sender"></param>
  /// <param name="e"></param>
        private void BookSorting_Load(object sender, EventArgs e)
        {
            
            // Wire up the button click event handler.
            PlayBT.Click += PlayBT_Click;

            // Initialize the progress bar.
            InitializeProgressBar();
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Initialize the progress bar.
        /// </summary>
        // this snip of code came from chatGPT 
        private void InitializeProgressBar()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10; // Assuming 10 books in the correct order.
            progressBar1.Value = 0;
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
       /// <summary>
       /// Play button to start the game
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void PlayBT_Click(object sender, EventArgs e)
        {
            GenerateRandomBooks();
            
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
       /// <summary>
       /// The generate method for all the calls numbers, all the colours of the books, the font of the text
       /// </summary>
        private void GenerateRandomBooks()
        {
            Random random = new Random();
            HashSet<string> usedCallNumbers = new HashSet<string>();
            HashSet<Color> usedColors = new HashSet<Color>();

            // Clear previously generated books.
            BottomShelfPanel.Controls.Clear();
            books.Clear();

            int xOffset = 10; // Horizontal position offset for each book.

            for (int i = 0; i < 10; i++)
            {
                // Generate a unique random number.
                int randomTopic;
                do
                {
                    randomTopic = random.Next(1, 101); // Adjust the range as needed.
                } while (usedCallNumbers.Contains($"{randomTopic:D3}"));

                string randomAuthorPrefix;
                do
                {
                    randomAuthorPrefix = GenerateRandomAuthorPrefix(random);
                } while (usedCallNumbers.Contains($"{randomTopic:D3} {randomAuthorPrefix}"));

                string callNumber = $"{randomTopic:D3} {randomAuthorPrefix}";
                
                usedCallNumbers.Add(callNumber);

                Color randomColor;
                do
                {
                    randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                } while (usedColors.Contains(randomColor));
                usedColors.Add(randomColor);

                PictureBox bookPictureBox = new PictureBox();
                bookPictureBox.Name = $"bookPictureBox{i}";
                bookPictureBox.Tag = i;
                bookPictureBox.Size = new Size(85, 90);
                bookPictureBox.BackColor = randomColor;

                Label bookLabel = new Label();
                bookLabel.Text = callNumber;
                bookLabel.ForeColor = Color.Black;
                bookLabel.Font = new Font("Arial", 12, FontStyle.Bold);
                bookLabel.TextAlign = ContentAlignment.MiddleCenter;

                bookPictureBox.Controls.Add(bookLabel);

                bookPictureBox.MouseDown += BookPictureBox_MouseDown;
                bookPictureBox.AllowDrop = true;
                bookPictureBox.DragDrop += BookPictureBox_DragDrop;
                bookPictureBox.DragEnter += BookPictureBox_DragEnter;

                bookPictureBox.Location = new Point(xOffset, 10);
                xOffset += bookPictureBox.Width + 10;

                BottomShelfPanel.Controls.Add(bookPictureBox);

                var book = new Book(bookPictureBox, callNumber);
                books.Add(book);

                correctOrder.Clear();
                correctOrder.AddRange(books.OrderBy(books => book.CallNumber));

                InitializeProgressBar();
            }
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// The author generation method that will geerate the 3 letters for the book
        /// </summary>
        /// <param name="random"></param>
        /// <returns></returns>
        // this snippet was taken and modified from chatGPT
        private string GenerateRandomAuthorPrefix(Random random)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char firstLetter = alphabet[random.Next(alphabet.Length)];
            char secondLetter = alphabet[random.Next(alphabet.Length)];
            char thirdLetter = alphabet[random.Next(alphabet.Length)];

            return $"{firstLetter}{secondLetter}{thirdLetter}";
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
/// <summary>
/// sort button to give the corrcet acending order of books
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void SortBT_Click(object sender, EventArgs e)
        {
            
            // Sort the books based on their random numbers (ascending order).
            books = books.OrderBy(book => book.CallNumber).ToList();

            // Update the positions of PictureBox controls in BottomShelfPanel to reflect the new order.
            int xOffset = 10;
            foreach (var book in books)
            {
                book.PictureBox.Location = new Point(xOffset, 10);
                xOffset += book.PictureBox.Width + 10;
            }

        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
       /// <summary>
       /// Check button, this will check if the user is on the right track to solving the puzzle and filled the progress bar
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void CheckBT_Click(object sender, EventArgs e)
        {
            // Check if the current order matches the correct order.
            bool isOrderCorrect = CheckOrder();

            if (isOrderCorrect)
            {
                // Increment the progress bar by 10% if the order is correct.
                progressBar1.Value += 1;
                MessageBox.Show("Correct order! Progress increased by 10%.");
            }
            else
            {
                MessageBox.Show("Incorrect order. Please try again.");
            }
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
       /// <summary>
       /// The following is code that will allow the user to drag and drop the picture boxes
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void BookPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Start the drag-and-drop operation when the left mouse button is clicked.
                PictureBox bookPictureBox = (PictureBox)sender;
                bookPictureBox.DoDragDrop(bookPictureBox, DragDropEffects.Move);
            }
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        private void BookPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            // Allow only Move drag effect to indicate that the PictureBox can be dropped.
            e.Effect = DragDropEffects.Move;
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        private void BookPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            // Handle the DragDrop event to rearrange the books.
            PictureBox draggedPictureBox = (PictureBox)e.Data.GetData(typeof(PictureBox));
            PictureBox targetPictureBox = (PictureBox)sender;

            // Swap their positions in the UI.
            Point tempLocation = draggedPictureBox.Location;
            draggedPictureBox.Location = targetPictureBox.Location;
            targetPictureBox.Location = tempLocation;

            // Update the Position property of the associated Book objects.
            var draggedBook = books.First(book => book.PictureBox == draggedPictureBox);
            var targetBook = books.First(book => book.PictureBox == targetPictureBox);

            int tempPosition = draggedBook.Position;
            draggedBook.Position = targetBook.Position;
            targetBook.Position = tempPosition;
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
         /// <summary>
         /// This is the book class where all the methods for certain variables
         /// </summary>
        public class Book
        {
            public PictureBox PictureBox { get; }
            public string CallNumber { get; }
            public int Position { get; set; }

            public Book(PictureBox pictureBox, string callNumber)
            {
                PictureBox = pictureBox;
                CallNumber = callNumber;
            }
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// bool method to check if the order of books is correct
        /// </summary>
        /// <returns></returns>
       private bool CheckOrder()
{
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].CallNumber != correctOrder[i].CallNumber)
                {
                    return false;
                }
            }
            return true;
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// music player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookSorting_Load_1(object sender, EventArgs e)
        {
            //plays background music
            player.controls.play();

            //disable the maximize feature
            MaximizeBox = false;
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
       /// <summary>
       /// home page button that will take you back to the home page
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void HomePageBT_Click(object sender, EventArgs e)
        {
            //this method was modified by YouTube
            //the channel is Code Conclusion
            //link to video: https://youtu.be/6AVghOqSYUs?si=spFgskdkpnS5H3Cd
            Form1 form1 = new Form1();
            form1.Show();
            Visible = false;

            //stops the background music being played
            player.controls.stop();
        }
    }
}
//------------------------------------------------------------ End of code ---------------------------------------------------------------------------------------------------------------------//
