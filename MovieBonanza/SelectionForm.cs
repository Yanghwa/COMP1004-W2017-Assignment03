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
        SplashForm splash = new SplashForm();
        private string[] _movieInformation = new string[3];
        public string[] MovieInformation {
            get
            {
                return _movieInformation;
            }
        }
        public SelectionForm()
        {
            InitializeComponent();
            splash.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.Hide();
        }
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(_movieInformation[0]) || string.IsNullOrEmpty(_movieInformation[1]) || string.IsNullOrEmpty(_movieInformation[2]))
            {
                MessageBox.Show("You have to check any movie", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                OrderForm order = new OrderForm();
                order.previousForm = this;
                order.Initialize();
                this.Hide();
                order.Show();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _movieInformation[0] = MovieListBox.SelectedItem.ToString();
            DetectCategory(_movieInformation[0]);
            DetectCost(_movieInformation[1]);
            TitleTextBox.Text = _movieInformation[0];
            CategoryTextBox.Text = _movieInformation[1];
            CostTextBox.Text = "$" + _movieInformation[2];

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="title"></param>
        private void DetectCategory(string title)
        {
            switch(title) {
                case "Season of the Witch":
                    _movieInformation[1] = "Sci-Fi";
                    SmallMoviePictureBox.Image = Properties.Resources.sci_fi;
                    break;
                case "The Green Hornet":
                    _movieInformation[1] = "Action";
                    SmallMoviePictureBox.Image = Properties.Resources.action;
                    break;
                case "The Dilemma":
                    _movieInformation[1] = "Comedy";
                    SmallMoviePictureBox.Image = Properties.Resources.comedy;
                    break;
                case "Death Race 2":
                    _movieInformation[1] = "Action";
                    SmallMoviePictureBox.Image = Properties.Resources.action;
                    break;
                case "Company Men":
                    _movieInformation[1] = "Drama";
                    SmallMoviePictureBox.Image = Properties.Resources.drama;
                    break;
                case "No Strings Attached":
                    _movieInformation[1] = "Comedy";
                    SmallMoviePictureBox.Image = Properties.Resources.comedy;
                    break;
                case "The Way Back":
                    _movieInformation[1] = "Drama";
                    SmallMoviePictureBox.Image = Properties.Resources.drama;
                    break;
                case "The Mechanic":
                    _movieInformation[1] = "Action";
                    SmallMoviePictureBox.Image = Properties.Resources.action;
                    break;
                case "The Rite":
                    _movieInformation[1] = "Horror";
                    SmallMoviePictureBox.Image = Properties.Resources.horror;
                    break;
                case "Sanctum":
                    _movieInformation[1] = "Action";
                    SmallMoviePictureBox.Image = Properties.Resources.action;
                    break;
                case "The Other Woman":
                    _movieInformation[1] = "Action";
                    SmallMoviePictureBox.Image = Properties.Resources.action;
                    break;
                case "The Roommate":
                    _movieInformation[1] = "Thriller";
                    SmallMoviePictureBox.Image = Properties.Resources.thriller;
                    break;
                case "Waiting for Forever":
                    _movieInformation[1] = "Drama";
                    SmallMoviePictureBox.Image = Properties.Resources.drama;
                    break;
                case "Cedar Rapids":
                    _movieInformation[1] = "Comedy";
                    SmallMoviePictureBox.Image = Properties.Resources.comedy;
                    break;
                case "Gnomeo and Juliet":
                    _movieInformation[1] = "Family";
                    SmallMoviePictureBox.Image = Properties.Resources.family;
                    break;
                case "Just Go With It":
                    _movieInformation[1] = "Comedy";
                    SmallMoviePictureBox.Image = Properties.Resources.comedy;
                    break;
                case "The Eagle":
                    _movieInformation[1] = "Action";
                    SmallMoviePictureBox.Image = Properties.Resources.action;
                    break;
                case "I am Number Four":
                    _movieInformation[1] = "Sci-Fi";
                    SmallMoviePictureBox.Image = Properties.Resources.sci_fi;
                    break;
                case "Footloose":
                    _movieInformation[1] = "New Release";
                    SmallMoviePictureBox.Image = Properties.Resources.new_release;
                    break;
                case "Real Steel":
                    _movieInformation[1] = "New Release";
                    SmallMoviePictureBox.Image = Properties.Resources.new_release;
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 
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
                case "New Releases":
                    _movieInformation[2] = "4.99";
                    break;
                default:
                    break;
            }
        }
    }
}
