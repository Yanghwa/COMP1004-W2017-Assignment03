//FileName: SelectionForm.cs
//FileType: Visual C# Source file
//Author: Junghwan Yang
//Student ID: 200320739
//Created On: 28/02/2017
//Copy Rights: Junghwan Yang
//Description: This app shows the information of selected movie including cost, image, category and title.

/////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza
{
    public partial class SelectionForm : Form
    {
        //INSTANCE CLASS-----------------
        SplashForm splash = new SplashForm();
        //PRIVATE INSTANCE VARIABLES-----------------
        private string[] _movieInformation = new string[3];
        private Image _bigPictureImage;

        //CONSTRUCTORS-------------------
        public SelectionForm()
        {
            InitializeComponent();
            splash.Show();
        }

        //EVENT HANDLERS-------------------------------
        /// <summary>
        /// This method hides this form first to show the logo in splash form
        /// </summary>
        /// <param name="e"></param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.Hide();
        }
        /// <summary>
        /// This method sets the timer, after setting time, splash form will be hidden and shows selection form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.SplashTimer.Enabled = false;
            splash.Hide();
            this.Show();
        }
        /// <summary>
        /// This method shows the order form when you click the next button. To make sure, checks again if the list is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickNextButton(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(_movieInformation[0]) || string.IsNullOrEmpty(_movieInformation[1]) || string.IsNullOrEmpty(_movieInformation[2]))
            {
                MessageBox.Show("You have to check any movie", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                OrderForm order = new OrderForm();
                order.previousForm = this;
                order.InitializeOrder();
                this.Hide();
                order.Show();
            }
        }
        /// <summary>
        /// This method detects the list is changed depending on its index, and shows the information of selected movie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckSelectedIndexChangedMovieListBox(object sender, EventArgs e)
        {
            if(MovieListBox.SelectedIndex >= 0)
            {
                NextButton.Enabled = true;
                _movieInformation[0] = MovieListBox.SelectedItem.ToString();
                DetectCategory(_movieInformation[0]);
                DetectCost(_movieInformation[1]);
                TitleTextBox.Text = _movieInformation[0];
                CategoryTextBox.Text = _movieInformation[1];
                CostTextBox.Text = "$" + _movieInformation[2];
            }
            else
            {
                Console.Write(MovieListBox.SelectedIndex);
            }
        }
        /// <summary>
        /// This method sets the category and stores to array depending on the selected movie's title
        /// also sets the images for selection form and order form
        /// </summary>
        /// <param name="title"></param>
        private void DetectCategory(string title)
        {
            switch(title) {
                case "Season of the Witch":
                    _movieInformation[1] = "Sci-Fi";
                    SmallMoviePictureBox.Image = Properties.Resources.season_of_the_witch_small;
                    _bigPictureImage = Properties.Resources.Season_of_the_Witch_big;
                    break;
                case "The Green Hornet":
                    _movieInformation[1] = "Action";
                    SmallMoviePictureBox.Image = Properties.Resources.green_hornet_small;
                    _bigPictureImage = Properties.Resources.green_hornet_big;
                    break;
                case "The Dilemma":
                    _movieInformation[1] = "Comedy";
                    SmallMoviePictureBox.Image = Properties.Resources.the_dilemma_small;
                    _bigPictureImage = Properties.Resources.the_dilemma_big;
                    break;
                case "Death Race 2":
                    _movieInformation[1] = "Action";
                    SmallMoviePictureBox.Image = Properties.Resources.Death_Race_2_small;
                    _bigPictureImage = Properties.Resources.Death_Race_2_big;
                    break;
                case "Company Men":
                    _movieInformation[1] = "Drama";
                    SmallMoviePictureBox.Image = Properties.Resources.company_man_small;
                    _bigPictureImage = Properties.Resources.company_man_big;
                    break;
                case "No Strings Attached":
                    _movieInformation[1] = "Comedy";
                    SmallMoviePictureBox.Image = Properties.Resources.No_Strings_Attached_small;
                    _bigPictureImage = Properties.Resources.No_Strings_Attached_big;
                    break;
                case "The Way Back":
                    _movieInformation[1] = "Drama";
                    SmallMoviePictureBox.Image = Properties.Resources.the_way_back_small;
                    _bigPictureImage = Properties.Resources.the_way_back_big;
                    break;
                case "The Mechanic":
                    _movieInformation[1] = "Action";
                    SmallMoviePictureBox.Image = Properties.Resources.the_mechanic_small;
                    _bigPictureImage = Properties.Resources.the_mechanic_big;
                    break;
                case "The Rite":
                    _movieInformation[1] = "Horror";
                    SmallMoviePictureBox.Image = Properties.Resources.the_rite_small;
                    _bigPictureImage = Properties.Resources.the_rite_big;
                    break;
                case "Sanctum":
                    _movieInformation[1] = "Action";
                    SmallMoviePictureBox.Image = Properties.Resources.Sanctum_small;
                    _bigPictureImage = Properties.Resources.Sanctum_big;
                    break;
                case "The Other Woman":
                    _movieInformation[1] = "Action";
                    SmallMoviePictureBox.Image = Properties.Resources.Moves_TheOtherWoman_small;
                    _bigPictureImage = Properties.Resources.Moves_TheOtherWoman_big;
                    break;
                case "The Roommate":
                    _movieInformation[1] = "Thriller";
                    SmallMoviePictureBox.Image = Properties.Resources.roommate_small;
                    _bigPictureImage = Properties.Resources.roommate_big;
                    break;
                case "Waiting for Forever":
                    _movieInformation[1] = "Drama";
                    SmallMoviePictureBox.Image = Properties.Resources.Waiting_for_Forever_small;
                    _bigPictureImage = Properties.Resources.Waiting_for_Forever_big;
                    break;
                case "Cedar Rapids":
                    _movieInformation[1] = "Comedy";
                    SmallMoviePictureBox.Image = Properties.Resources.CedarRapids_small;
                    _bigPictureImage = Properties.Resources.Cedar_Rapids_big;
                    break;
                case "Gnomeo and Juliet":
                    _movieInformation[1] = "Family";
                    SmallMoviePictureBox.Image = Properties.Resources.GnomeoandJuliet_small;
                    _bigPictureImage = Properties.Resources.GnomeoandJuliet_big;
                    break;
                case "Just Go With It":
                    _movieInformation[1] = "Comedy";
                    SmallMoviePictureBox.Image = Properties.Resources.Just_Go_with_It_small;
                    _bigPictureImage = Properties.Resources.Just_Go_with_It_big;
                    break;
                case "The Eagle":
                    _movieInformation[1] = "Action";
                    SmallMoviePictureBox.Image = Properties.Resources.The_Eagle_small;
                    _bigPictureImage = Properties.Resources.The_Eagle_big;
                    break;
                case "I am Number Four":
                    _movieInformation[1] = "Sci-Fi";
                    SmallMoviePictureBox.Image = Properties.Resources.I_Am_Number_Four_small;
                    _bigPictureImage = Properties.Resources.I_Am_Number_Four_big;
                    break;
                case "Footloose":
                    _movieInformation[1] = "New Release";
                    SmallMoviePictureBox.Image = Properties.Resources.Footloose_small;
                    _bigPictureImage = Properties.Resources.Footloose_big;
                    break;
                case "Real Steel":
                    _movieInformation[1] = "New Release";
                    SmallMoviePictureBox.Image = Properties.Resources.Real_Steel_small;
                    _bigPictureImage = Properties.Resources.Real_Steel_big;
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// This method sets the cost and stores to array depending on the selected movie's category
        /// </summary>
        /// <param name="category"></param>
        private void DetectCost(string category)
        {
            switch(category)
            {
                case "Comedy":
                    _movieInformation[2] = "1.99";
                    break;
                case "Drama":
                    _movieInformation[2] = "1.99";
                    break;
                case "Action":
                    _movieInformation[2] = "2.99";
                    break;
                case "Sci-Fi":
                    _movieInformation[2] = "2.99";
                    break;
                case "Horror":
                    _movieInformation[2] = "2.99";
                    break;
                case "Thriller":
                    _movieInformation[2] = "1.99";
                    break;
                case "Family":
                    _movieInformation[2] = "0.99";
                    break;
                case "New Release":
                    _movieInformation[2] = "4.99";
                    break;
                default:
                    break;
            }
        }
        //PUBLIC METHODS------------------------
        /// <summary>
        /// This method is getter to get string array including information of selected movie
        /// </summary>
        public string[] MovieInformation
        {
            get
            {
                return _movieInformation;
            }
        }
        /// <summary>
        /// This methods is getter to get bigger image than selection form's image
        /// </summary>
        public Image BigPictureImage
        {
            get
            {
                return _bigPictureImage;
            }
        }
        
    }
}
