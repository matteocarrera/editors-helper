namespace Editor_Helper
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.AboutButton = new System.Windows.Forms.Button();
            this.TutorialButton = new System.Windows.Forms.Button();
            this.CreateReportButton = new System.Windows.Forms.Button();
            this.TimeLimitButton = new System.Windows.Forms.Button();
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.KeysPressedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.KeysLabel = new System.Windows.Forms.Label();
            this.KeysInfoLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeInfoLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.CurrentTimer = new System.Windows.Forms.Timer(this.components);
            this.gbMenu.SuspendLayout();
            this.gbActions.SuspendLayout();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeysPressedChart)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            this.gbMenu.BackColor = System.Drawing.Color.Transparent;
            this.gbMenu.Controls.Add(this.AboutButton);
            this.gbMenu.Controls.Add(this.TutorialButton);
            this.gbMenu.Controls.Add(this.CreateReportButton);
            this.gbMenu.Controls.Add(this.TimeLimitButton);
            this.gbMenu.Controls.Add(this.ChooseFileButton);
            this.gbMenu.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbMenu.Location = new System.Drawing.Point(12, 15);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(156, 171);
            this.gbMenu.TabIndex = 0;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Меню";
            // 
            // AboutButton
            // 
            this.AboutButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutButton.Location = new System.Drawing.Point(1, 139);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(0);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.AboutButton.Size = new System.Drawing.Size(154, 30);
            this.AboutButton.TabIndex = 7;
            this.AboutButton.Text = "О программе";
            this.AboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // TutorialButton
            // 
            this.TutorialButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.TutorialButton.FlatAppearance.BorderSize = 0;
            this.TutorialButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.TutorialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TutorialButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TutorialButton.Location = new System.Drawing.Point(1, 109);
            this.TutorialButton.Margin = new System.Windows.Forms.Padding(0);
            this.TutorialButton.Name = "TutorialButton";
            this.TutorialButton.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TutorialButton.Size = new System.Drawing.Size(154, 30);
            this.TutorialButton.TabIndex = 6;
            this.TutorialButton.Text = "Обучение";
            this.TutorialButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TutorialButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TutorialButton.UseVisualStyleBackColor = true;
            this.TutorialButton.Click += new System.EventHandler(this.TutorialButton_Click);
            // 
            // CreateReportButton
            // 
            this.CreateReportButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CreateReportButton.Enabled = false;
            this.CreateReportButton.FlatAppearance.BorderSize = 0;
            this.CreateReportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CreateReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateReportButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateReportButton.Location = new System.Drawing.Point(1, 79);
            this.CreateReportButton.Margin = new System.Windows.Forms.Padding(0);
            this.CreateReportButton.Name = "CreateReportButton";
            this.CreateReportButton.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.CreateReportButton.Size = new System.Drawing.Size(154, 30);
            this.CreateReportButton.TabIndex = 5;
            this.CreateReportButton.Text = "Создать отчет";
            this.CreateReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateReportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateReportButton.UseVisualStyleBackColor = true;
            this.CreateReportButton.Click += new System.EventHandler(this.CreateReportButton_Click);
            // 
            // TimeLimitButton
            // 
            this.TimeLimitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.TimeLimitButton.FlatAppearance.BorderSize = 0;
            this.TimeLimitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.TimeLimitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeLimitButton.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLimitButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TimeLimitButton.Location = new System.Drawing.Point(1, 49);
            this.TimeLimitButton.Name = "TimeLimitButton";
            this.TimeLimitButton.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.TimeLimitButton.Size = new System.Drawing.Size(154, 30);
            this.TimeLimitButton.TabIndex = 2;
            this.TimeLimitButton.Text = "Лимит времени";
            this.TimeLimitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimeLimitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TimeLimitButton.UseVisualStyleBackColor = true;
            this.TimeLimitButton.Click += new System.EventHandler(this.TimeLimitButton_Click);
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.AutoSize = true;
            this.ChooseFileButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChooseFileButton.FlatAppearance.BorderSize = 0;
            this.ChooseFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ChooseFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseFileButton.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChooseFileButton.Location = new System.Drawing.Point(1, 19);
            this.ChooseFileButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.ChooseFileButton.Size = new System.Drawing.Size(154, 30);
            this.ChooseFileButton.TabIndex = 1;
            this.ChooseFileButton.Text = "Выбрать файл";
            this.ChooseFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChooseFileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChooseFileButton.UseVisualStyleBackColor = true;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // gbActions
            // 
            this.gbActions.BackColor = System.Drawing.Color.Transparent;
            this.gbActions.Controls.Add(this.StopButton);
            this.gbActions.Controls.Add(this.PauseButton);
            this.gbActions.Controls.Add(this.StartButton);
            this.gbActions.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbActions.Location = new System.Drawing.Point(12, 192);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(156, 111);
            this.gbActions.TabIndex = 6;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Действия";
            // 
            // StopButton
            // 
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.StopButton.Enabled = false;
            this.StopButton.FlatAppearance.BorderSize = 0;
            this.StopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopButton.Location = new System.Drawing.Point(1, 79);
            this.StopButton.Margin = new System.Windows.Forms.Padding(0);
            this.StopButton.Name = "StopButton";
            this.StopButton.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.StopButton.Size = new System.Drawing.Size(154, 30);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Остановить";
            this.StopButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.PauseButton.Enabled = false;
            this.PauseButton.FlatAppearance.BorderSize = 0;
            this.PauseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.PauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseButton.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PauseButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PauseButton.Location = new System.Drawing.Point(1, 49);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PauseButton.Size = new System.Drawing.Size(154, 30);
            this.PauseButton.TabIndex = 2;
            this.PauseButton.Text = "Пауза";
            this.PauseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PauseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.AutoSize = true;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.StartButton.Enabled = false;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartButton.Location = new System.Drawing.Point(1, 19);
            this.StartButton.Margin = new System.Windows.Forms.Padding(0);
            this.StartButton.Name = "StartButton";
            this.StartButton.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.StartButton.Size = new System.Drawing.Size(154, 30);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Старт";
            this.StartButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbInfo.Controls.Add(this.KeysPressedChart);
            this.gbInfo.Controls.Add(this.KeysLabel);
            this.gbInfo.Controls.Add(this.KeysInfoLabel);
            this.gbInfo.Controls.Add(this.TimeLabel);
            this.gbInfo.Controls.Add(this.TimeInfoLabel);
            this.gbInfo.Controls.Add(this.NameLabel);
            this.gbInfo.Controls.Add(this.InfoLabel);
            this.gbInfo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbInfo.Location = new System.Drawing.Point(174, 15);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(366, 288);
            this.gbInfo.TabIndex = 7;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Информация";
            // 
            // KeysPressedChart
            // 
            this.KeysPressedChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            chartArea1.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.Title = "Минуты";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Century Gothic", 8.5F);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            chartArea1.AxisY.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.Title = "Количество";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Century Gothic", 8.5F);
            chartArea1.Name = "ChartArea1";
            this.KeysPressedChart.ChartAreas.Add(chartArea1);
            this.KeysPressedChart.Location = new System.Drawing.Point(9, 134);
            this.KeysPressedChart.Name = "KeysPressedChart";
            this.KeysPressedChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.KeysPressedChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(209)))), ((int)(((byte)(60)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            series1.Name = "Keys";
            series1.Points.Add(dataPoint1);
            this.KeysPressedChart.Series.Add(series1);
            this.KeysPressedChart.Size = new System.Drawing.Size(351, 148);
            this.KeysPressedChart.TabIndex = 6;
            title1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            title1.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold);
            title1.Name = "MainTitle";
            title1.Text = "Количество вводимых символов в минуту:";
            this.KeysPressedChart.Titles.Add(title1);
            // 
            // KeysLabel
            // 
            this.KeysLabel.AutoSize = true;
            this.KeysLabel.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeysLabel.Location = new System.Drawing.Point(6, 119);
            this.KeysLabel.Name = "KeysLabel";
            this.KeysLabel.Size = new System.Drawing.Size(15, 17);
            this.KeysLabel.TabIndex = 5;
            this.KeysLabel.Text = "0";
            // 
            // KeysInfoLabel
            // 
            this.KeysInfoLabel.AutoSize = true;
            this.KeysInfoLabel.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeysInfoLabel.Location = new System.Drawing.Point(6, 103);
            this.KeysInfoLabel.Name = "KeysInfoLabel";
            this.KeysInfoLabel.Size = new System.Drawing.Size(186, 16);
            this.KeysInfoLabel.TabIndex = 4;
            this.KeysInfoLabel.Text = "Количество нажатий клавиш:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(6, 81);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(56, 17);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "00:00:00";
            // 
            // TimeInfoLabel
            // 
            this.TimeInfoLabel.AutoSize = true;
            this.TimeInfoLabel.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeInfoLabel.Location = new System.Drawing.Point(6, 65);
            this.TimeInfoLabel.Name = "TimeInfoLabel";
            this.TimeInfoLabel.Size = new System.Drawing.Size(133, 16);
            this.TimeInfoLabel.TabIndex = 2;
            this.TimeInfoLabel.Text = "Времени затрачено:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoEllipsis = true;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(6, 43);
            this.NameLabel.MaximumSize = new System.Drawing.Size(360, 17);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(140, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "-документ не выбран-";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(6, 27);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(138, 16);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Название документа:";
            // 
            // CurrentTimer
            // 
            this.CurrentTimer.Interval = 10;
            this.CurrentTimer.Tick += new System.EventHandler(this.CurrentTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 319);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.gbMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Burone Editor\'s Helper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            this.gbActions.ResumeLayout(false);
            this.gbActions.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeysPressedChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button ChooseFileButton;
        private System.Windows.Forms.Button TimeLimitButton;
        private System.Windows.Forms.Button CreateReportButton;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button TutorialButton;
        private System.Windows.Forms.Timer CurrentTimer;
        internal System.Windows.Forms.Label TimeLabel;
        internal System.Windows.Forms.Label TimeInfoLabel;
        internal System.Windows.Forms.Label InfoLabel;
        internal System.Windows.Forms.Label NameLabel;
        internal System.Windows.Forms.Label KeysLabel;
        internal System.Windows.Forms.Label KeysInfoLabel;
        internal System.Windows.Forms.DataVisualization.Charting.Chart KeysPressedChart;
        internal System.Windows.Forms.Button PauseButton;
    }
}

