namespace Editor_Helper
{
    partial class TimeLimit
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
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HoursLimit = new System.Windows.Forms.NumericUpDown();
            this.MinutesLimit = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.HoursLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите лимит времени";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.AutoSize = true;
            this.ConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ConfirmButton.FlatAppearance.BorderSize = 0;
            this.ConfirmButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfirmButton.Location = new System.Drawing.Point(108, 75);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(0);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ConfirmButton.Size = new System.Drawing.Size(154, 30);
            this.ConfirmButton.TabIndex = 3;
            this.ConfirmButton.Text = "Подтвердить";
            this.ConfirmButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(138, 44);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(44, 17);
            this.HoursLabel.TabIndex = 4;
            this.HoursLabel.Text = "часов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "минут";
            // 
            // HoursLimit
            // 
            this.HoursLimit.Location = new System.Drawing.Point(88, 40);
            this.HoursLimit.Name = "HoursLimit";
            this.HoursLimit.Size = new System.Drawing.Size(44, 21);
            this.HoursLimit.TabIndex = 7;
            // 
            // MinutesLimit
            // 
            this.MinutesLimit.Location = new System.Drawing.Point(188, 40);
            this.MinutesLimit.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinutesLimit.Name = "MinutesLimit";
            this.MinutesLimit.Size = new System.Drawing.Size(44, 21);
            this.MinutesLimit.TabIndex = 8;
            // 
            // TimeLimit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 114);
            this.Controls.Add(this.MinutesLimit);
            this.Controls.Add(this.HoursLimit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeLimit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Лимит времени";
            ((System.ComponentModel.ISupportInitialize)(this.HoursLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown HoursLimit;
        private System.Windows.Forms.NumericUpDown MinutesLimit;
    }
}