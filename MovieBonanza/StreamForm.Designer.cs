namespace MovieBonanza
{
    partial class StreamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OKButton = new System.Windows.Forms.Button();
            this.ThankLabel = new System.Windows.Forms.Label();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.SelectedMovieLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OKButton.Location = new System.Drawing.Point(179, 282);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 50);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.ClickOKButton);
            // 
            // ThankLabel
            // 
            this.ThankLabel.AutoSize = true;
            this.ThankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ThankLabel.Location = new System.Drawing.Point(33, 39);
            this.ThankLabel.Name = "ThankLabel";
            this.ThankLabel.Size = new System.Drawing.Size(426, 29);
            this.ThankLabel.TabIndex = 6;
            this.ThankLabel.Text = "Thank you for chooing Movie Bonanza!";
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GrandTotalLabel.Location = new System.Drawing.Point(55, 111);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(240, 26);
            this.GrandTotalLabel.TabIndex = 7;
            this.GrandTotalLabel.Text = "Grand Total Information";
            // 
            // SelectedMovieLabel
            // 
            this.SelectedMovieLabel.AutoSize = true;
            this.SelectedMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SelectedMovieLabel.Location = new System.Drawing.Point(55, 179);
            this.SelectedMovieLabel.Name = "SelectedMovieLabel";
            this.SelectedMovieLabel.Size = new System.Drawing.Size(116, 26);
            this.SelectedMovieLabel.TabIndex = 7;
            this.SelectedMovieLabel.Text = "Movie Title";
            // 
            // StreamForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(478, 344);
            this.ControlBox = false;
            this.Controls.Add(this.SelectedMovieLabel);
            this.Controls.Add(this.GrandTotalLabel);
            this.Controls.Add(this.ThankLabel);
            this.Controls.Add(this.OKButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StreamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label ThankLabel;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.Label SelectedMovieLabel;
    }
}