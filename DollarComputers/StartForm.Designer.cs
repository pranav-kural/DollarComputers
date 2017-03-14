namespace DollarComputers
{
    partial class StartForm
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
            this.OrderLabel = new System.Windows.Forms.Label();
            this.StartNewOrderButton = new System.Windows.Forms.Button();
            this.SavedOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CoinImagePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CoinImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.OrderLabel.Location = new System.Drawing.Point(46, 27);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(276, 22);
            this.OrderLabel.TabIndex = 0;
            this.OrderLabel.Text = "Order Your Computer Today!";
            // 
            // StartNewOrderButton
            // 
            this.StartNewOrderButton.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.StartNewOrderButton.Location = new System.Drawing.Point(100, 239);
            this.StartNewOrderButton.Name = "StartNewOrderButton";
            this.StartNewOrderButton.Size = new System.Drawing.Size(162, 39);
            this.StartNewOrderButton.TabIndex = 2;
            this.StartNewOrderButton.Text = "Start a New Order";
            this.StartNewOrderButton.UseVisualStyleBackColor = true;
            // 
            // SavedOrderButton
            // 
            this.SavedOrderButton.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.SavedOrderButton.Location = new System.Drawing.Point(100, 296);
            this.SavedOrderButton.Name = "SavedOrderButton";
            this.SavedOrderButton.Size = new System.Drawing.Size(162, 39);
            this.SavedOrderButton.TabIndex = 3;
            this.SavedOrderButton.Text = "Open a Saved Order";
            this.SavedOrderButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.ExitButton.Location = new System.Drawing.Point(100, 351);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(162, 39);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // CoinImagePictureBox
            // 
            this.CoinImagePictureBox.BackgroundImage = global::DollarComputers.Properties.Resources.coin_image;
            this.CoinImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CoinImagePictureBox.Location = new System.Drawing.Point(100, 64);
            this.CoinImagePictureBox.Name = "CoinImagePictureBox";
            this.CoinImagePictureBox.Size = new System.Drawing.Size(162, 155);
            this.CoinImagePictureBox.TabIndex = 1;
            this.CoinImagePictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 416);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SavedOrderButton);
            this.Controls.Add(this.StartNewOrderButton);
            this.Controls.Add(this.CoinImagePictureBox);
            this.Controls.Add(this.OrderLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.ShowIcon = false;
            this.Text = "Welcome to the Dollar Computer!";
            ((System.ComponentModel.ISupportInitialize)(this.CoinImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.PictureBox CoinImagePictureBox;
        private System.Windows.Forms.Button StartNewOrderButton;
        private System.Windows.Forms.Button SavedOrderButton;
        private System.Windows.Forms.Button ExitButton;
    }
}