using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace MovieBonanza
{

    public partial class OrderForm : Form
    {
        public SelectionForm previousForm;
        private double _subTotal = 0;
        private double _salesTaxRatio = 0.13;
        private double _salesTax = 0;
        private double _grandTotal = 0;
        private double DVDAdded = 0;

        public double GrandTotal
        {
            get
            {
                return _grandTotal;
            }
        }


        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamButton_Click(object sender, EventArgs e)
        {
            StreamForm stream = new StreamForm();
            stream.previousForm = this;
            stream.Initailize();
            this.Hide();
            stream.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        public void Initialize()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            TitleTextBox.Text = previousForm.MovieInformation[0];
            CategoryTextBox.Text = previousForm.MovieInformation[1];
            CostTextBox.Text = "$" + previousForm.MovieInformation[2];
            BigMoviePictureBox.Image = previousForm.BigPictureImage;
            _subTotal = double.Parse(previousForm.MovieInformation[2]) + DVDAdded;
            _salesTax = _salesTaxRatio * _subTotal;
            _grandTotal = _subTotal + _salesTax;
            SubTotalTextBox.Text = "$" + string.Format("{0:#,##0.00}", _subTotal);
            SalesTaxTextBox.Text = "$" + string.Format("{0:#,##0.00}", _salesTax);
            GrandTotalTextBox.Text = "$" + string.Format("{0:#,##0.00}", _grandTotal);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            if(DVDCheckBox.Checked == true)
            {
                DVDAdded = 10.00;
                DVDLabel.Visible = true;
                DVDTextBox.Visible = true;
                DVDTextBox.Text = "$" + string.Format("{0:#,##0.00}", DVDAdded);
                Initialize();

            }
            else
            {
                DVDAdded = 0;
                DVDLabel.Visible = false;
                DVDTextBox.Visible = false;
                Initialize();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string DVDPreview = "\nDVD: " + DVDTextBox.Text;
            if (DVDCheckBox.Checked == true)
            {
                
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
    }
}
