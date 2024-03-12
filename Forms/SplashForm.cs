using System;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class SplashForm : BaseForm
    {
        private MainForm _mainForm;

        public SplashForm()
        {
            InitializeComponent();
            Cursor = Cursors.Arrow;
            progressBar.Value = 0;
            timerProgress.Start();
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 2;

            // Stop Condition
            if (progressBar.Value < 100) return;

            // Init MainForm
            timerProgress.Stop();

            _mainForm = new MainForm();
            _mainForm.FormClosed += MainForm_FormClosed;
            _mainForm.Show();

            Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}