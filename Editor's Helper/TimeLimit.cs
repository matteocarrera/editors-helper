using System;
using System.Windows.Forms;

namespace Editor_Helper
{
    public partial class TimeLimit : Form
    {
        public int limitInSeconds;

        public TimeLimit()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            limitInSeconds = Convert.ToInt32(HoursLimit.Value * 60 + MinutesLimit.Value) * 60; 
                DialogResult = DialogResult.OK;
                Close();
        }
    }
}
