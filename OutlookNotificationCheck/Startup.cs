using System;
using System.Windows.Forms;

namespace OutlookNotificationCheck
{
    public class Startup
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
