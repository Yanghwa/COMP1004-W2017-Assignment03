//FileName: OrderForm.cs
//FileType: Visual C# Source file
//Author: Junghwan Yang
//Student ID: 200320739
//Created On: 28/02/2017
//Copy Rights: Junghwan Yang
//Description: This app shows the information of selected movie including cost, image, category and title.
//      Also shows the bigger image than selection form and calculates cost including tax and option.

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

    public partial class OrderForm : Form
    {
        //PUBLIC CLASS-----------------------
        public SelectionForm previousForm;
        
        //PRIVATE INSTANCE VARIABLES---------------
        private double _subTotal = 0;
        private double _salesTaxRatio = 0.13;
        private double _salesTax = 0;
        private double _grandTotal = 0;
        private double _costDVDAdded = 0;

        //CONSTRUCTORS-----------------------------
        public OrderForm()
        {
            InitializeComponent();
        }

        //EVENT HANDELER --------------------------------
        /// <summary>
        /// This method shows the stream form when you click the stream button and menu-stream 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickStreamButton(object sender, EventArgs e)
        {
            StreamForm stream = new StreamForm();
            stream.previousForm = this;
            stream.InitailizeStreamForm();
            this.Hide();
            stream.Show();
        }
        
        /// <summary>
        /// This method shows the selection form again when you click the back button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickBackButton(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }
        /// <summary>
        /// This method show the about box when you click the about menu buttom on the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickAboutToolStripMenuItem(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }
        /// <summary>
        /// This method detects if a list is clicked or not, and show the option depending on check status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckedChangedDVDCheckBox(object sender, EventArgs e)
        {
            if(DVDCheckBox.Checked == true)
            {
                _costDVDAdded = 10.00;
                DVDLabel.Visible = true;
                DVDTextBox.Visible = true;
                DVDTextBox.Text = "$" + string.Format("{0:#,##0.00}", _costDVDAdded);
                InitializeOrder();
            }
            else
            {
                _costDVDAdded = 0;
                DVDLabel.Visible = false;
                DVDTextBox.Visible = false;
                InitializeOrder();
            }
        }
        /// <summary>
        /// This method closes the form when you click the cancel button and menu-cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickCancelButton(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This method show the brief information via message box when you click the print menu on the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickPrintToolStripMenuItem(object sender, EventArgs e)
        {
            string DVDPreview = "\nDVD: " + DVDTextBox.Text;
            if (DVDCheckBox.Checked == true)
            {
                Console.Write("DVD option is on");
            }
            else
            {
                DVDPreview = "";
            }
            MessageBox.Show("Title: " + TitleTextBox.Text +
                    "\nCategory: " + CategoryTextBox.Text + "\nCost: "
                + CostTextBox.Text + DVDPreview
                + "\nSubTotal: " + SubTotalTextBox.Text + "\nGrand Total: "
                + GrandTotalTextBox.Text, "Print Preview");

        }
        //PUBLIC METHODS------------------------
        /// <summary>
        /// This method gets the data from selection form and shows on the form
        /// </summary>
        public void InitializeOrder()
        {
            TitleTextBox.Text = previousForm.MovieInformation[0];
            CategoryTextBox.Text = previousForm.MovieInformation[1];
            CostTextBox.Text = "$" + previousForm.MovieInformation[2];
            BigMoviePictureBox.Image = previousForm.BigPictureImage;
            _subTotal = double.Parse(previousForm.MovieInformation[2]) + _costDVDAdded;
            _salesTax = _salesTaxRatio * _subTotal;
            _grandTotal = _subTotal + _salesTax;
            SubTotalTextBox.Text = "$" + string.Format("{0:#,##0.00}", _subTotal);
            SalesTaxTextBox.Text = "$" + string.Format("{0:#,##0.00}", _salesTax);
            GrandTotalTextBox.Text = "$" + string.Format("{0:#,##0.00}", _grandTotal);
        }
        /// <summary>
        /// This method is getter to get the value of grand total
        /// </summary>
        public double GrandTotal
        {
            get
            {
                return _grandTotal;
            }
        }

    }
}
