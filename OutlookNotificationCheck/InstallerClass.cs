using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace OutlookNotificationCheck
{
    [RunInstaller(true)]
    public partial class InstallerClass : System.Configuration.Install.Installer
    {
        public InstallerClass()
        {
            InitializeComponent();
        }

        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);

            Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Process.Start(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\OutlookNotificationCheck.exe");
        }
    }
}
