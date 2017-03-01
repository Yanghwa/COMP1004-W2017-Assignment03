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
        public SelectionForm previousForm;
        private double _subTotal = 0;
        private double _salesTaxRatio = 0.13;
        private double _salesTax = 0;
        private double _grandTotal = 0;
        
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
            this.Hide();
            stream.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        public void Initialize()
        {
            TitleTextBox.Text = previousForm.MovieInformation[0];
            CategoryTextBox.Text = previousForm.MovieInformation[1];
            CostTextBox.Text = previousForm.MovieInformation[2];
            BigMoviePictureBox.Image = previousForm.SmallMoviePictureBox.Image;
            _subTotal = double.Parse(previousForm.MovieInformation[2]);
            _salesTax = _salesTaxRatio * _subTotal;
            _grandTotal = _subTotal + _salesTax;
            SubTotalTextBox.Text = _subTotal.ToString();
            SalesTaxTextBox.Text = _salesTax.ToString();
            GrandTotalTextBox.Text = _grandTotal.ToString();
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
    }
}
