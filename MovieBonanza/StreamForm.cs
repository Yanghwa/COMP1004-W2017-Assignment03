//FileName: StreamForm.cs
//FileType: Visual C# Source file
//Author: Junghwan Yang
//Student ID: 200320739
//Created On: 28/02/2017
//Copy Rights: Junghwan Yang
//Description: This app shows the information of selected movie including cost and title. Thank you massege.

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
    public partial class StreamForm : Form
    {
        //PUBLIC CLASS--------
        public OrderForm previousForm;

        //CONSTRUCTORS--------------------
        public StreamForm()
        {
            InitializeComponent();
        }

        //EVENT HANDLERS--------------------------
        /// <summary>
        /// This method close the application when click the ok button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickOKButton(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //PUBLIC METHODS------------------------------------
        /// <summary>
        /// This method get the data from order form and selection form to display the brief information of selected movie
        /// </summary>
        public void InitailizeStreamForm()
        {
            GrandTotalLabel.Text = "Your Credit card will be charged " + string.Format("{0:#,##0.00}", previousForm.GrandTotal) + " dollars";
            SelectedMovieLabel.Text = previousForm.previousForm.MovieInformation[0] +" " + "will begin streaming shortly";
        }
    }
}
