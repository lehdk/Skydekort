using System;
using System.Collections.Generic;
using System.Text;

namespace LehSerializer
{
    public class LehSaver
    {
        public static void WriteToXML(object obj, string path, Type objType)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(objType);
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, obj);
            file.Close();
        }
    }
}
