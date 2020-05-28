using System;
using System.Text;
using System.Windows.Forms;

namespace OutlookNotificationCheck
{
    
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
        }

        /// <summary>
        /// Activates the timer and sets the form to invisible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            tmrWindow.Enabled = true;
            this.Size = new System.Drawing.Size(0, 0);           
        }

        /// <summary>
        /// Checks if a reminder window is visible and puts it into the foreground if so.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrWindow_Tick(object sender, EventArgs e)
        {
            const uint SWP_NOMOVE = 0x1;
            IntPtr TOPMOST = new IntPtr(-1);

            try
            {
                IntPtr reminderWindowHandle = FindReminderWindow(100);
                
                if (WindowUtility.IsWindowVisible(reminderWindowHandle))
                {
                    WindowUtility.ShowWindow(reminderWindowHandle, 1);
                    WindowUtility.SetWindowPos(reminderWindowHandle, TOPMOST, 0, 0, 0, 0, SWP_NOMOVE);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                
            }
        }

        /// <summary>
        /// Finds eventual reminder windows.
        /// </summary>
        /// <param name="iUB">Equals the count of the reminders.</param>
        /// <returns></returns>
        private IntPtr FindReminderWindow(int iUB)
        {
            try
            {
                int i = 1;
                IntPtr reminderWindow;
                do
                {
                    reminderWindow = WindowUtility.FindWindow(null, $"{i} Erinnerung(en)");
                    i++;
                }
                while (i < iUB && reminderWindow.Equals(0));
                return reminderWindow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return new IntPtr(0);
            }
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
