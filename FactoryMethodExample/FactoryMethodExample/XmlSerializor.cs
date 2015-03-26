using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace FactoryMethodExample
{
    class XmlSerializor: ISerializer
    {

        public string SerializeMyObject(object obj)
        {
            XmlSerializer ser;
            StringWriter sww;
            try
            {
                ser = new XmlSerializer(obj.GetType());
                sww = new StringWriter();
                XmlTextWriter writer = new XmlTextWriter(sww);
                ser.Serialize(writer, obj);
                string xml = sww.ToString();
                //sww.Close();
                //writer.Close();
                return xml;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            //string xmlString = null;
            //XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
            //using (MemoryStream memoryStream = new MemoryStream())
            //{
            //    xmlSerializer.Serialize(memoryStream, obj);
            //    memoryStream.Position = 0;
            //    xmlString = new StreamReader(memoryStream).ReadToEnd();
            //}
            //return xmlString;

            
        }
    }
}
