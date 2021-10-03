using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using dao;

namespace Slc_Mercado
{
    public  static class LocalFileManager
    {

         static LocalFileManager()
        {

            Console.WriteLine("--------------------------------------");
            var fileName = Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.ApplicationData), "test.txt");

           
        }

        public static void SerializeObject2<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(fileName);
                }
            }
            catch (Exception ex)
            {
                //Log exception here
                ex = ex;
            }
        }


        public static T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            T objectOut = default(T);

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                //Log exception here
            }

            return objectOut;
        }

        public static string SerializeArrayList(ArrayList obj)

        {

            System.Xml.XmlDocument doc = new XmlDocument();

            Type[] extraTypes = new Type[1];

            extraTypes[0] = typeof(Empresa);

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(ArrayList), extraTypes);

            System.IO.MemoryStream stream = new System.IO.MemoryStream();

            try

            {

                serializer.Serialize(stream, obj);

                stream.Position = 0;

                doc.Load(stream);

                return doc.InnerXml;

            }

            catch { throw; }

            finally

            {

                stream.Close();

                stream.Dispose();

            }

        }


    }
}