﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Calendar_System.model
{
    public class Serializer
    {
        public Serializer()
        {

        }

        public void SerializeObject(string filename, SerializeEntries objectToSerialize)
        {
            Stream stream = File.Open(filename, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, objectToSerialize);
            stream.Close();
        }

        public SerializeEntries DeSerializeObject(string filename)
        {
            SerializeEntries objectToSerialize;
            Stream stream = File.Open(filename, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            objectToSerialize = (SerializeEntries)bFormatter.Deserialize(stream);
            stream.Close();
            return objectToSerialize;
        }
    }
}
