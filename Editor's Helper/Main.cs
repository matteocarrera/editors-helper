using System;
using System.Windows.Forms;

namespace Editor_Helper
{
    public partial class Main : Form
    {
        private WorkingDocument _document;
        private TimeSpan _timeLeft;
        internal TimeSpan _currentTimer;
        private int _timerTicks;
        private bool _timeLimitIsActive = false;

        public Main()
        {
            InitializeComponent(); 
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _document = new WorkingDocument(this);
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            using (Files files = new Files())
            {
                if (files.ShowDialog() == DialogResult.OK)
                {
                    NameLabel.Text = files.fileName;
                    StartButton.Enabled = true;
                    CreateReportButton.Enabled = false;
                }
            }
        }

        private void TimeLimitButton_Click(object sender, EventArgs e)
        {
            using (TimeLimit form = new TimeLimit())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _timeLeft = TimeSpan.FromSeconds(form.limitInSeconds);
                    _timeLimitIsActive = true;

                    TimeLabel.Text = "00:00:00 / " + _timeLeft.ToString();
                }
            }   
        }

        private void CreateReportButton_Click(object sender, EventArgs e)
        {
            Report report = new Report(this, GetReportPath());
            report.Create();
        }

        private void TutorialButton_Click(object sender, EventArgs e)
        {
            Tutorial tutorial = new Tutorial();
            tutorial.ShowDialog();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (StopButton.Enabled == false) ResetData();

            _document.InactiveTimer = 1;
            _document.KeysCounter = 0;

            CurrentTimer.Start();

            _document.gHook.hook();

            SetAvailability(false, false, true, true, false);

            WindowState = FormWindowState.Minimized;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            CurrentTimer.Stop();

            _document.gHook.unhook();

            SetAvailability(false, true, false, true, false);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            CurrentTimer.Stop();

            _document.gHook.unhook();

            SetAvailability(true, true, false, false, true);

            CreateReportButton.Enabled = true;
        }

        private void ResetData()
        {
            _timerTicks = 0;
            KeysPressedChart.Series["Keys"].Points.Clear();
            KeysPressedChart.Series["Keys"].Points.AddXY(0, 0);
            KeysPressedChart.ChartAreas[0].AxisX.Minimum = 0;
            KeysLabel.Text = "0";
        }

        private void SetAvailability(bool fileIsActive, bool startIsActive, bool pauseIsActive, bool stopIsActive, bool limitIsActive)
        {
            ChooseFileButton.Enabled = fileIsActive;
            StartButton.Enabled = startIsActive;
            PauseButton.Enabled = pauseIsActive;
            StopButton.Enabled = stopIsActive;
            TimeLimitButton.Enabled = limitIsActive;
        }

        private void CurrentTimer_Tick(object sender, EventArgs e)
        {
            _timerTicks += 1;
            _currentTimer = TimeSpan.FromSeconds(_timerTicks);

            if (_timerTicks % 60 == 0)
            {
                KeysPressedChart.ChartAreas[0].AxisX.Maximum = _timerTicks / 60;
                KeysPressedChart.Series["Keys"].Points.AddXY(_timerTicks / 60, _document.KeysCounter);
                _document.KeysCounter = 0;
                _document.ProcessExists();
            }
             
            if (_timeLimitIsActive == true)
            {
                TimeLabel.Text = _currentTimer.ToString() + " / " + _timeLeft.ToString();

                if (_currentTimer >= _timeLeft) StopButton.PerformClick();
            }
            else
            {
                TimeLabel.Text = _currentTimer.ToString();
            }

            _document.UserIsActive();
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closingDialog = MessageBox.Show("Вы действительно хотите выйти из программы?", 
                                                         "Выход из программы Burone Editor's Helper", 
                                                         MessageBoxButtons.YesNo);
            if (closingDialog == DialogResult.Yes) e.Cancel = false;
            else e.Cancel = true;
        }

        private string GetReportPath()
        {
            SaveFileDialog dlg = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                FilterIndex = 0
            };

            string filePath = string.Empty;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filePath = dlg.FileName;
            }

            return filePath;
        }
    }
}