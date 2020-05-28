using System;

namespace OutlookNotificationCheck
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tmrWindow = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuIconSysTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuIconSysTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrWindow
            // 
            this.tmrWindow.Interval = 10000;
            this.tmrWindow.Tick += new System.EventHandler(this.tmrWindow_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuIconSysTray;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "OutlookNotificationCheck";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuIconSysTray
            // 
            this.contextMenuIconSysTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.contextMenuIconSysTray.Name = "contextMenuIconSysTray";
            this.contextMenuIconSysTray.Size = new System.Drawing.Size(121, 26);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(151, 26);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "OutlookNotificationCheck";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuIconSysTray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Timer tmrWindow;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuIconSysTray;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
    }
}

