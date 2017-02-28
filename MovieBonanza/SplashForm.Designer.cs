namespace MovieBonanza
{
    partial class SplashForm
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
            this.MovieBonanzaLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MovieBonanzaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieBonanzaLogo
            // 
            this.MovieBonanzaLogo.Image = global::MovieBonanza.Properties.Resources.logo;
            this.MovieBonanzaLogo.Location = new System.Drawing.Point(-2, 1);
            this.MovieBonanzaLogo.Name = "MovieBonanzaLogo";
            this.MovieBonanzaLogo.Size = new System.Drawing.Size(501, 401);
            this.MovieBonanzaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MovieBonanzaLogo.TabIndex = 0;
            this.MovieBonanzaLogo.TabStop = false;
            // 
            // SplashForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.ControlBox = false;
            this.Controls.Add(this.MovieBonanzaLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            ((System.ComponentModel.ISupportInitialize)(this.MovieBonanzaLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MovieBonanzaLogo;
    }
}