﻿using System;
using System.Windows.Forms;

namespace Calendar_System.Utility
{
    public class SyncForm : Form
    {
        private Button _syncButton;
        private SyncControl _syncControl;
        public SyncForm(SyncControl syncControl)
        {
            _syncControl = syncControl;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this._syncButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _syncButton
            // 
            this._syncButton.Location = new System.Drawing.Point(13, 199);
            this._syncButton.Name = "_syncButton";
            this._syncButton.Size = new System.Drawing.Size(257, 44);
            this._syncButton.TabIndex = 0;
            this._syncButton.Text = "Sync";
            this._syncButton.UseVisualStyleBackColor = true;
            this._syncButton.Click += new System.EventHandler(this._syncButton_Click);
            // 
            // SyncForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this._syncButton);
            this.Name = "SyncForm";
            this.ResumeLayout(false);

        }

        private void _syncButton_Click(object sender, EventArgs e)
        {
            _syncControl.SyncWithDb();
        }   
    }
}
