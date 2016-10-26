using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace MagusTools
{
    static class XMLChecker
    {
        private static XElement xmlDefaults = new XElement("root");
        private static bool IsInitialized = false;
        private static string currentFileLocation;

        public static List<string> Check()
        {
            if (!IsInitialized) Initialize();

            IEnumerable<XElement> nodes = xmlDefaults.Elements();

            foreach (var node in nodes)
            {
                if (!Stats.statNames.Contains((string)node))
                {
                    Console.WriteLine("Suspicious -> " + node);
                }
            }

            return new List<string>();
        }

        private static void Initialize()
        {
            string path = Directory.GetCurrentDirectory();

            currentFileLocation = path + @"\SkillData.xml";

            Console.WriteLine("Loading file from " + currentFileLocation);

            if (LoadXML(currentFileLocation))
            {
                IsInitialized = true;
            }
        }

        private static bool LoadXML(string xmlPath)
        {
            try
            {
                xmlDefaults.RemoveAll();
                xmlDefaults = XElement.Load(xmlPath);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}