﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calendar_System.control;

namespace Calendar_System.view
{
    public class LoginForm : Form
    {
        private CalendarControl _cControl;
        private Button _cancelButton;
        private Label _userNameLable;
        private Label _passwordLabel;
        private TextBox _userNameTB;
        private TextBox _passwordTB;
        private Button _loginButton;

        public LoginForm(CalendarControl calendarControl)
        {
            _cControl = calendarControl;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this._loginButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._userNameLable = new System.Windows.Forms.Label();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._userNameTB = new System.Windows.Forms.TextBox();
            this._passwordTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _loginButton
            // 
            this._loginButton.Location = new System.Drawing.Point(13, 211);
            this._loginButton.Name = "_loginButton";
            this._loginButton.Size = new System.Drawing.Size(130, 32);
            this._loginButton.TabIndex = 0;
            this._loginButton.Text = "Login";
            this._loginButton.UseVisualStyleBackColor = true;
            this._loginButton.Click += new System.EventHandler(this._loginButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Location = new System.Drawing.Point(149, 211);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(121, 32);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // _userNameLable
            // 
            this._userNameLable.AutoSize = true;
            this._userNameLable.Location = new System.Drawing.Point(10, 9);
            this._userNameLable.Name = "_userNameLable";
            this._userNameLable.Size = new System.Drawing.Size(81, 17);
            this._userNameLable.TabIndex = 1;
            this._userNameLable.Text = "User name:";
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Location = new System.Drawing.Point(10, 38);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(73, 17);
            this._passwordLabel.TabIndex = 3;
            this._passwordLabel.Text = "Password:";
            // 
            // _userNameTB
            // 
            this._userNameTB.Location = new System.Drawing.Point(97, 9);
            this._userNameTB.Name = "_userNameTB";
            this._userNameTB.Size = new System.Drawing.Size(173, 22);
            this._userNameTB.TabIndex = 2;
            // 
            // _passwordTB
            // 
            this._passwordTB.Location = new System.Drawing.Point(97, 38);
            this._passwordTB.Name = "_passwordTB";
            this._passwordTB.PasswordChar = '*';
            this._passwordTB.Size = new System.Drawing.Size(173, 22);
            this._passwordTB.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this._passwordTB);
            this.Controls.Add(this._userNameTB);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._userNameLable);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._loginButton);
            this.Name = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void _loginButton_Click(object sender, EventArgs e)
        {
            bool loginStatus = _cControl.CheckLogin(_userNameTB.Text, _passwordTB.Text);
            if (loginStatus)
            {
                this.Dispose();
                _cControl.SuccesfullLogin();
            }
        }

        private void _cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
