using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace MagusTools
{
    public class XMLHandler
    {
        /// <summary>
        /// Stores the XMl elements
        /// </summary>
        private XElement xmlDefaults = new XElement("root");

        // Was used for something in the past
        private bool IsInitialized = false;

        /// <summary>
        /// Stores the current location of the XML file
        /// </summary>
        private string currentFileLocation;

        /// <summary>
        /// The constructor loads the default XML datafile
        /// </summary>
        public XMLHandler()
        {
            // Assuming the XML data is in the same directory as the executable
            string path = Directory.GetCurrentDirectory();

            currentFileLocation = path + @"\SkillData.xml";

            Console.WriteLine("Loading file from " + currentFileLocation);


            if (LoadXML(ref xmlDefaults, currentFileLocation))
            {
                IsInitialized = true;
            }
        }

        /// <summary>
        /// Clears the specified XElement node then loads the content of an XML file into it.
        /// </summary>
        /// <param name="nodes">A reference to the XElement node to be filled.</param>
        /// <param name="xmlPath">Set the path of the XML file.</param>
        /// <returns>Returns <see cref="true"/> if successful.</returns>
        public bool LoadXML(ref XElement nodes, string xmlPath)
        {
            try
            {
                nodes.RemoveAll();
                nodes = XElement.Load(xmlPath);

                Console.WriteLine("Loaded " + xmlPath + " with " + nodes.Descendants().Count() + " nodes");
                return true;
            }
            catch
            {
                Console.WriteLine("Could not load " + xmlPath + "!");
                return false;
            }
        }
    }
}