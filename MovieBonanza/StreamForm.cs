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
        public OrderForm previousForm;
        public StreamForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 
        /// </summary>
        public void Initailize()
        {
            GrandTotalLabel.Text = "Your Credit card will be charged " + string.Format("{0:#,##0.00}", previousForm.GrandTotal) + " dollars";
            SelectedMovieLabel.Text = previousForm.previousForm.MovieInformation[0] +" " + "will begin streaming shortly";
        }
    }
}
