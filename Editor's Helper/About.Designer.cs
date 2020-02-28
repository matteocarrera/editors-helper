namespace Editor_Helper
{
    partial class About
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
            this.titleText = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.versionText = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Location = new System.Drawing.Point(60, 64);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(135, 17);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "Burone Editor\'s Helper";
            // 
            // Logo
            // 
            this.Logo.ImageLocation = "";
            this.Logo.Location = new System.Drawing.Point(34, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(186, 45);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // versionText
            // 
            this.versionText.AutoSize = true;
            this.versionText.Location = new System.Drawing.Point(91, 88);
            this.versionText.Name = "versionText";
            this.versionText.Size = new System.Drawing.Size(72, 17);
            this.versionText.TabIndex = 2;
            this.versionText.Text = "Версия 1.0";
            // 
            // yearText
            // 
            this.yearText.AutoSize = true;
            this.yearText.Location = new System.Drawing.Point(104, 112);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(46, 17);
            this.yearText.TabIndex = 3;
            this.yearText.Text = "2020 г.";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 140);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.versionText);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.titleText);
            this.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label versionText;
        private System.Windows.Forms.Label yearText;
    }
}