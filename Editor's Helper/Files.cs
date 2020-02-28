using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Editor_Helper
{
    public partial class Files : Form
    {
        public string fileName;

        public Files()
        {
            InitializeComponent();
            GetFilesNames();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                fileName = FilesList.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch { }
        }

        private void GetFilesNames()
        {
            List<string> allowedProgramms = new List<string>
            {
                "Word",
                "Excel",
                "PowerPoint",
            };

            Process[] procs = Process.GetProcesses();

            foreach (Process p in procs)
            {
                string program = p.MainWindowTitle;
                if (allowedProgramms.Any(type => program.Contains(type)))
                    FilesList.Items.Add(program);
            }
        }
    }
}
