﻿using System;
using System.Windows.Forms;
using Calendar_System.AccountSubSystem;
using Calendar_System.StorageSubSystem;

namespace Calendar_System.MainSystem
{
    public class ClientForm : Form
    {
        private bool _isAdmin;
        private IAbstractStorage _abstractStorage;
        private CalendarControl _cControl;
        private Button _createEntryButton;
        private Button _modifyEntryButton;
        private Button _syncButton;
        private Button _adminLoginButton;
        private ÁbstractCalendar _calendarView;

        public ClientForm(CalendarControl cControl, IAbstractStorage abstractStorage, bool isAdmin)
        {
            _isAdmin = isAdmin;
            _abstractStorage = abstractStorage;
            _cControl = cControl;
            _calendarView = new CalendarWeekly();
            InitializeComponent();
        }
        //Changes the view from weekView to monthView and vice versa.
        private void ChangeView()
        {
            if (_calendarView.GetType() == typeof(CalendarWeekly))
            {
                _calendarView = new CalendarMonthly();
            }
            else
            {
                _calendarView = new CalendarWeekly();
            }
        }

        private void InitializeComponent()
        {
            this._createEntryButton = new System.Windows.Forms.Button();
            this._modifyEntryButton = new System.Windows.Forms.Button();
            this._syncButton = new System.Windows.Forms.Button();
            this._adminLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _createEntryButton
            // 
            this._createEntryButton.Location = new System.Drawing.Point(12, 332);
            this._createEntryButton.Name = "_createEntryButton";
            this._createEntryButton.Size = new System.Drawing.Size(161, 29);
            this._createEntryButton.TabIndex = 0;
            this._createEntryButton.Text = "Create new entry";
            this._createEntryButton.UseVisualStyleBackColor = true;
            this._createEntryButton.Click += new System.EventHandler(this._createEntryButton_Click);
            // 
            // _modifyEntryButton
            // 
            this._modifyEntryButton.Location = new System.Drawing.Point(12, 367);
            this._modifyEntryButton.Name = "_modifyEntryButton";
            this._modifyEntryButton.Size = new System.Drawing.Size(161, 29);
            this._modifyEntryButton.TabIndex = 1;
            this._modifyEntryButton.Text = "Modify existing entry";
            this._modifyEntryButton.UseVisualStyleBackColor = true;
            this._modifyEntryButton.Click += new System.EventHandler(this._modifyEntryButton_Click);
            // 
            // _syncButton
            // 
            this._syncButton.Location = new System.Drawing.Point(331, 332);
            this._syncButton.Name = "_syncButton";
            this._syncButton.Size = new System.Drawing.Size(197, 29);
            this._syncButton.TabIndex = 3;
            this._syncButton.Text = "Sync with Google Calendar";
            this._syncButton.UseVisualStyleBackColor = true;
            this._syncButton.Click += new System.EventHandler(this._syncButton_Click);
            // 
            // _adminLoginButton
            // 
            this._adminLoginButton.Location = new System.Drawing.Point(331, 367);
            this._adminLoginButton.Name = "_adminLoginButton";
            this._adminLoginButton.Size = new System.Drawing.Size(197, 29);
            this._adminLoginButton.TabIndex = 4;
            this._adminLoginButton.Text = "Login as administrator";
            this._adminLoginButton.UseVisualStyleBackColor = true;
            this._adminLoginButton.Click += new System.EventHandler(this._adminLoginButton_Click);
            // 
            // ClientForm
            // 
            this.ClientSize = new System.Drawing.Size(540, 408);
            this.Controls.Add(this._adminLoginButton);
            this.Controls.Add(this._syncButton);
            this.Controls.Add(this._modifyEntryButton);
            this.Controls.Add(this._createEntryButton);
            this.Name = "ClientForm";
            this.ResumeLayout(false);

        }

        private void _createEntryButton_Click(object sender, EventArgs e)
        {
            _cControl.CreateEntryControl("newEntry");
        }

        private void _modifyEntryButton_Click(object sender, EventArgs e)
        {
            _cControl.CreateEntryControl("modifyEntry");
        }

        private void _syncButton_Click(object sender, EventArgs e)
        {
            _cControl.CreateSyncControl();
        }

        private void _adminLoginButton_Click(object sender, EventArgs e)
        {
            if (_isAdmin)
            {
                _cControl.CreateAdminControl();
            }
            else
            {
                //TODO Error frame: User not administrator
            }
        }
    }
}
