﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calendar_System.model;
using Calendar_System.view;

namespace Calendar_System.control
{
    public class WorkgroupControl
    {
        public void WorkGroupFormCreateWorkgroup()
        {
            var workgroupForm = new WorkgroupForm();
        }

        public void ModifyWorkgroup(Workgroup workgroup)
        {
            var workgroupForm = new WorkgroupForm(workgroup);
        }

        public void DeleteWordgroup(Workgroup workgroup)
        {
            
        }
    }
}
