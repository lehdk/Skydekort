using System;
using System.Collections.Generic;
using System.Text;

namespace LehSerializer
{
    public class LehLoader
    {
        public static object ReadXML(string path, Type objType)
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(objType);
            System.IO.StreamReader file = new System.IO.StreamReader(path);

            object toReturn = reader.Deserialize(file);
            file.Close();
            return toReturn;
        }
    }
}
