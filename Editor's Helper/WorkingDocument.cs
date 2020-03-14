using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Editor_Helper
{
    class WorkingDocument
    {
        public int KeysCounter { get; set; }
        public int InactiveTimer { get; set; }
        private readonly Main _main;
        public GlobalKeyboardHook gHook;
        private readonly int[] _unusedKeys = { 37, 38, 39, 40, 93, 164 };

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        public WorkingDocument(Main main)
        {
            _main = main;

            SetKeyboardHook();
        }

        private void SetKeyboardHook()
        {
            gHook = new GlobalKeyboardHook();
            gHook.KeyDown += new KeyEventHandler(KeyDownHandler);
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
                gHook.HookedKeys.Add(key);
        }

        public void UserIsActive()
        {
            if (GetActiveProcessFileName() != _main.NameLabel.Text) InactiveTimer++;
            else InactiveTimer = 1;

            if (InactiveTimer / 60 >= 5) SetWarningWindow("Вы не были активны более 5 минут, подсчет времени остановлен.");
        }

        private string GetActiveProcessFileName()
        {
            IntPtr hwnd = GetForegroundWindow();
            GetWindowThreadProcessId(hwnd, out uint pid);
            Process p = Process.GetProcessById((int)pid);
            return p.MainWindowTitle;
        }

        public void ProcessExists()
        {
            Process[] procs = Process.GetProcesses();
            bool processExists = false;

            foreach (Process p in procs)
            {
                string program = p.MainWindowTitle;
                if (program == _main.NameLabel.Text) processExists = true;
            }

            if (!processExists) SetWarningWindow("Редактируемый файл был закрыт, подсчет времени остановлен.");
        }

        private void SetWarningWindow(string message)
        {
            _main.PauseButton.PerformClick();

            _main.WindowState = FormWindowState.Normal;

            MessageBox.Show(message,
                            "Остановка времени",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void KeyDownHandler(object sender, KeyEventArgs e)
        {
            if (GetActiveProcessFileName() == _main.NameLabel.Text && !Array.Exists(_unusedKeys, element => element == e.KeyValue))
            {
                KeysCounter++;
                _main.KeysLabel.Text = (Convert.ToInt32(_main.KeysLabel.Text) + 1).ToString();
            }
        }
    }
}
