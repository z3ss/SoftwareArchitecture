﻿using System;
using System.Collections.Generic;
using System.Net;

namespace Calendar_System.EntrySubSystem.Adapter
{
    class GoogleAdapter : IAdapter
    {
        private string _path = "https://www.googleapis.com/calendar/v3";
        private HttpListener _httpListener; //hmm

        public void CreateEntry(Entry entry)
        {
            throw new NotImplementedException();
        }

        public Entry GetEntry()
        {
            throw new NotImplementedException();
        }

        public void ModifyEntry(Entry entry)
        {
            throw new NotImplementedException();
        }

        public List<Entry> GetEntries()
        {
            throw new NotImplementedException();
        }

        public void SendEntries(List<Entry> entries)
        {
            throw new NotImplementedException();
        }

        public void Authorize(string user, string password)
        {
            throw new NotImplementedException();
        }
    }
}
