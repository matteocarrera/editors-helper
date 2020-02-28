namespace Editor_Helper
{
    partial class Files
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
            this.FilesList = new System.Windows.Forms.ListBox();
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.gbFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilesList
            // 
            this.FilesList.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilesList.FormattingEnabled = true;
            this.FilesList.ItemHeight = 16;
            this.FilesList.Location = new System.Drawing.Point(6, 23);
            this.FilesList.Name = "FilesList";
            this.FilesList.Size = new System.Drawing.Size(516, 228);
            this.FilesList.TabIndex = 0;
            // 
            // gbFiles
            // 
            this.gbFiles.Controls.Add(this.ConfirmButton);
            this.gbFiles.Controls.Add(this.FilesList);
            this.gbFiles.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbFiles.Location = new System.Drawing.Point(12, 15);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Size = new System.Drawing.Size(528, 292);
            this.gbFiles.TabIndex = 1;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "Список активных документов:";
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
            this.ConfirmButton.Location = new System.Drawing.Point(187, 255);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(0);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ConfirmButton.Size = new System.Drawing.Size(154, 30);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "Подтвердить";
            this.ConfirmButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // Files
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 319);
            this.Controls.Add(this.gbFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Files";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор файла";
            this.gbFiles.ResumeLayout(false);
            this.gbFiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FilesList;
        private System.Windows.Forms.GroupBox gbFiles;
        private System.Windows.Forms.Button ConfirmButton;
    }
}