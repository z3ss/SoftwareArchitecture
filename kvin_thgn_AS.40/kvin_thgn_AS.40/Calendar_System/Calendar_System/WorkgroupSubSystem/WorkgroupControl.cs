﻿using System.Collections.Generic;
using System.Diagnostics;
using Calendar_System.AccountSubSystem;
using Calendar_System.StorageSubSystem;

namespace Calendar_System.WorkgroupSubSystem
{
    public class WorkgroupControl
    {
        private IAbstractStorage _abstractStorage;
        public WorkgroupControl(string message, IAbstractStorage abstractStorage)
        {
            _abstractStorage = abstractStorage;
            if (message == "newWorkgroup")
            {
                WorkgroupFormCreateWorkgroup();
            }
            if (message == "modifyWorkgroup")
            {
                // Simulates searching - not implemented yet.
                var workgroup = new Workgroup("bla", new List<User>());
                WorkgroupFormModifyWorkgroup(workgroup);
            }
        }

        public void WorkgroupFormCreateWorkgroup()
        {
            var wgf = new WorkgroupForm();
            wgf.Show();
        }

        public void WorkgroupFormModifyWorkgroup(Workgroup workgroup)
        {
            var wgf = new WorkgroupForm(workgroup);
            wgf.Show();
        }
    }
}
