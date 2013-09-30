using DrawTogether.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DrawTogether.Extensions
{
    public class MySerializer
    {
        public static void SerializeObject(string FileName, object Data)
        {
            using (StreamWriter streamWriter = new StreamWriter(FileName))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(Data.GetType());
                xmlSerializer.Serialize(streamWriter, Data);
            }
        }

        public static object DeserializeObject(string FileName)
        {
            using (StreamReader streamWriter = new StreamReader(FileName))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(object));
                return xmlSerializer.Deserialize(streamWriter);
            }
        }
    }
}
