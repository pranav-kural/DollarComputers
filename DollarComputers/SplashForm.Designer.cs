namespace DollarComputers
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
            this.components = new System.ComponentModel.Container();
            this.DollarComputersLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.DollarComputerPictureBox = new System.Windows.Forms.PictureBox();
            this.SplashFormTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollarComputerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DollarComputersLabel
            // 
            this.DollarComputersLabel.AutoSize = true;
            this.DollarComputersLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DollarComputersLabel.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.DollarComputersLabel.Location = new System.Drawing.Point(325, 42);
            this.DollarComputersLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DollarComputersLabel.Name = "DollarComputersLabel";
            this.DollarComputersLabel.Size = new System.Drawing.Size(217, 33);
            this.DollarComputersLabel.TabIndex = 0;
            this.DollarComputersLabel.Text = "ollarComputers";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackgroundImage = global::DollarComputers.Properties.Resources.logo_img;
            this.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPictureBox.Location = new System.Drawing.Point(258, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(103, 82);
            this.LogoPictureBox.TabIndex = 1;
            this.LogoPictureBox.TabStop = false;
            // 
            // DollarComputerPictureBox
            // 
            this.DollarComputerPictureBox.BackgroundImage = global::DollarComputers.Properties.Resources.intro_hero;
            this.DollarComputerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DollarComputerPictureBox.Location = new System.Drawing.Point(2, 78);
            this.DollarComputerPictureBox.Name = "DollarComputerPictureBox";
            this.DollarComputerPictureBox.Size = new System.Drawing.Size(762, 328);
            this.DollarComputerPictureBox.TabIndex = 2;
            this.DollarComputerPictureBox.TabStop = false;
            // 
            // SplashFormTimer
            // 
            this.SplashFormTimer.Enabled = true;
            this.SplashFormTimer.Interval = 3000;
            this.SplashFormTimer.Tick += new System.EventHandler(this.SplashFormTimer_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 405);
            this.ControlBox = false;
            this.Controls.Add(this.DollarComputersLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.DollarComputerPictureBox);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.ShowIcon = false;
            this.Text = "Dollar Computers";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DollarComputerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DollarComputersLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.PictureBox DollarComputerPictureBox;
        private System.Windows.Forms.Timer SplashFormTimer;
    }
}

