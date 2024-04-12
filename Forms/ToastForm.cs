using System.Drawing;
using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public sealed partial class ToastForm : Form
    {
        private int _x, _y;
        private int _holdingTime = 1000;

        public ToastForm(string content, bool isWarning = false)
        {
            InitializeComponent();
            
            labelContent.Text = content;
            ShowInTaskbar = false;

            if (!isWarning) return;
            
            label.Text = "Warning";
            panel.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void ToastForm_Load(object sender, System.EventArgs e)
        {
            Position();
        }

        private void Position()
        {
            _x = Screen.PrimaryScreen.WorkingArea.Width - Width - 10;
            _y = Screen.PrimaryScreen.WorkingArea.Height - Height + 40;

            Location = new Point(_x, _y);
        }

        private void timerHide_Tick(object sender, System.EventArgs e)
        {
            if (_holdingTime < 0)
            {
                Location = new Point(_x, _y += 10);
                
                if (_y > Screen.PrimaryScreen.WorkingArea.Height)
                {
                    timerHide.Stop();
                    Close();
                }
                
                
            }
            else
            {
                _holdingTime -= 10;
            }
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            Location = new Point(_x, _y -= 10);

            if (_y < Screen.PrimaryScreen.WorkingArea.Height - Height - 30 - 5)
            {
                timer.Stop();
                timerHide.Start();
            }
        }
    }
}