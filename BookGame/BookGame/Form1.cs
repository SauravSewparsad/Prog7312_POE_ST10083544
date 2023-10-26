using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Button that will take you to the 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReplaceBookBT_Click(object sender, EventArgs e)
        {
            //this method was modified by YouTube
            //the channel is Code Conclusion
            //link to video: https://youtu.be/6AVghOqSYUs?si=spFgskdkpnS5H3Cd
            BookSorting bookSorting = new BookSorting();
            bookSorting.Show();
            Visible = false;
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
/// <summary>
/// this is the button that will take you to the identify game
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void IdentifyAreasBT_Click(object sender, EventArgs e)
        {
            //this method was modified by YouTube
            //the channel is Code Conclusion
            //link to video: https://youtu.be/6AVghOqSYUs?si=spFgskdkpnS5H3Cd
            //message box that will pop up when button is clicked
            ColumnMatch columnMatch = new ColumnMatch();
            columnMatch.Show();
            Visible = false;
        }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
       /// <summary>
       /// this is button to open the  finding game
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void FindingCallNoBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is still under construction");
        }
    }
}
//------------------------------------------------------------ End of code ---------------------------------------------------------------------------------------------------------------------//