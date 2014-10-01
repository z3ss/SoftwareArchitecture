﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar_System.model
{
    class StorageImp : AbstractStorage
    {
        private List<Entry> _entryList;
        private List<User> _userList;
        private List<Workgroup> _workgroupList; 
        public StorageImp()
        {
            _entryList = new List<Entry>();
            _userList = new List<User>();
            _workgroupList = new List<Workgroup>();
            User user1 = new User("Hans", "Hansen", "hans@itu.dk", "42913392");
            _userList.Add(user1);

            Entry entry1 = new Entry(new DateTime(2014, 10, 10), new DateTime(2014, 10, 10), "Atrium", _userList, "Meeting");
            _entryList.Add(entry1);

            Workgroup workgroup1 = new Workgroup("Lecturers", _userList);
            _workgroupList.Add(workgroup1);
        }

        public override List<Entry> GetEntriesForUser(User user)
        {
            List<Entry> entries = new List<Entry>();
            foreach (var entry in _entryList)
            {
                if (entry.UserList.Contains(user))
                {
                    entries.Add(entry);
                }
            }
            return entries;
        }

        public override void UpdateEntry(Entry entry)
        {
            throw new NotImplementedException();
        }

        public override void CreateEntry(Entry entry)
        {
            throw new NotImplementedException();
        }

        public override void DeleteEntry(Entry entry)
        {
            throw new NotImplementedException();
        }

        public override void CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public override List<User> GetUsers()
        {
            return _userList;
        }

        public override void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public override void CreateWorkgroup(Workgroup wg)
        {
            throw new NotImplementedException();
        }

        public override List<Workgroup> GetWorkgroups()
        {
            throw new NotImplementedException();
        }

        public override void DeleteWorkgroup(Workgroup wg)
        {
            throw new NotImplementedException();
        }
    }
}
