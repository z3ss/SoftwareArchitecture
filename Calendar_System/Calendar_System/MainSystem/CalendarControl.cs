﻿using System;
using System.Drawing.Text;
using System.Windows.Forms;
using Calendar_System.AccountSubSystem;
using Calendar_System.EntrySubSystem;
using Calendar_System.StorageSubSystem;
using Calendar_System.Utility;

namespace Calendar_System.MainSystem
{
    public class CalendarControl
    {
        private AbstractStorage _abstractStorage;
        // @Invariant: After SuccesfullLogin() _user is never null.
        public static IUser User { get; private set; }
        public CalendarControl()
        {
            _abstractStorage = new DatabaseFactory().CreateStorage("test");
            LoginForm loginForm = new LoginForm(this, _abstractStorage);
            loginForm.ShowDialog();
        }
        private void SuccesfullLogin()
        {
            ClientForm calendarClient = new ClientForm(this, _abstractStorage, User.GetAdmin());
            calendarClient.ShowDialog();
        }
        public void CreateEntryControl(String message)
        {
            EntryControl ec = new EntryControl(message, _abstractStorage);
        }

        public void CreateSyncControl()
        {
            SyncControl sc = new SyncControl(_abstractStorage);
        }
        public bool CheckLogin(string userName, string password)
        {
            User = _abstractStorage.CheckPassword(userName, password);
            if(User == null)
            {
                return false;
            }
            SuccesfullLogin();
            return true;
        }

        public void CreateAdminControl()
        {
            AdminControl adminControl = new AdminControl(_abstractStorage);
        }
    }
}
