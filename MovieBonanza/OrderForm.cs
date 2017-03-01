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
        public OrderForm()
        {
            InitializeComponent();
        }

        private void StreamButton_Click(object sender, EventArgs e)
        {
            StreamForm stream = new StreamForm();
            this.Hide();
            stream.Show();
        }

        public void Initialize()
        {
            TitleTextBox.Text = previousForm.MovieInformation[0];
            CategoryTextBox.Text = previousForm.MovieInformation[1];
            CostTextBox.Text = previousForm.MovieInformation[2];
            BigMoviePictureBox.Image = previousForm.SmallMoviePictureBox.Image;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }
    }
}
