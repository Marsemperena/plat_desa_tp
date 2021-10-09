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


namespace config
{
       class LocalFileManager
    {
        public static string userpath;

        static LocalFileManager()
        {
            userpath = Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData) + @"\\Mercado";
         

        }
    }
}