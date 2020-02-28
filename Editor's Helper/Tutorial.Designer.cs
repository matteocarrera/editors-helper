namespace Editor_Helper
{
    partial class Tutorial
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
            this.TutorialPicturesBox = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.TutorialTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TutorialPicturesBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TutorialPicturesBox
            // 
            this.TutorialPicturesBox.Location = new System.Drawing.Point(12, 12);
            this.TutorialPicturesBox.Name = "TutorialPicturesBox";
            this.TutorialPicturesBox.Size = new System.Drawing.Size(528, 270);
            this.TutorialPicturesBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TutorialPicturesBox.TabIndex = 0;
            this.TutorialPicturesBox.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackButton.Location = new System.Drawing.Point(12, 370);
            this.BackButton.Margin = new System.Windows.Forms.Padding(0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.BackButton.Size = new System.Drawing.Size(154, 30);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Назад";
            this.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.AutoSize = true;
            this.ForwardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ForwardButton.FlatAppearance.BorderSize = 0;
            this.ForwardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardButton.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForwardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ForwardButton.Location = new System.Drawing.Point(386, 370);
            this.ForwardButton.Margin = new System.Windows.Forms.Padding(0);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ForwardButton.Size = new System.Drawing.Size(154, 30);
            this.ForwardButton.TabIndex = 4;
            this.ForwardButton.Text = "Далее";
            this.ForwardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ForwardButton.UseVisualStyleBackColor = false;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // TutorialTextLabel
            // 
            this.TutorialTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TutorialTextLabel.AutoEllipsis = true;
            this.TutorialTextLabel.AutoSize = true;
            this.TutorialTextLabel.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TutorialTextLabel.Location = new System.Drawing.Point(12, 285);
            this.TutorialTextLabel.MaximumSize = new System.Drawing.Size(528, 51);
            this.TutorialTextLabel.MinimumSize = new System.Drawing.Size(528, 17);
            this.TutorialTextLabel.Name = "TutorialTextLabel";
            this.TutorialTextLabel.Size = new System.Drawing.Size(528, 17);
            this.TutorialTextLabel.TabIndex = 5;
            this.TutorialTextLabel.Text = "-текст не задан-";
            this.TutorialTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 409);
            this.Controls.Add(this.TutorialTextLabel);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TutorialPicturesBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tutorial";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tutorial";
            ((System.ComponentModel.ISupportInitialize)(this.TutorialPicturesBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TutorialPicturesBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Label TutorialTextLabel;
    }
}