using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Drawing;

namespace MagusTools
{
    public class XMLHandler
    {
        /// <summary>
        /// Stores the XMl elements
        /// </summary>
        private XElement xmlDefaults = new XElement("root");

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

            Program.eventLogger.Log(new object[] { "Loading file from ", Color.Blue, currentFileLocation } );

            if (LoadXML(ref xmlDefaults, currentFileLocation))
            {
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
                //nodes.RemoveAll();
                nodes = XElement.Load(xmlPath);

                Program.eventLogger.Log(new object[] { "Loaded ", Color.Cyan, nodes.Descendants().Count(), Color.Black, " nodes" } );
                return true;
            }
            catch
            {
                Program.eventLogger.Log(new object[] { "Could not load ", Color.IndianRed, xmlPath, Color.Black, "!" } );
                return false;
            }
        }

        public System.Windows.Forms.TreeNode[] GetSkillTree()
        {
            Program.eventLogger.Log(new object[] { "Fetching Skill Tree" } );

            var categories =
                from data in xmlDefaults.Elements("skills").Elements("skill")
                where data.Element("name").Attribute("language").Value == System.Threading.Thread.CurrentThread.CurrentCulture.Name
                select new
                {
                    name = data.Element("name").Value,
                    category = data.Attribute("category").Value,
                    subcategory = data.Attribute("subcategory").Value
                };

            categories.OrderBy(c => c.category).ThenBy(s => s.subcategory).ThenBy(n => n.name);

            System.Collections.Generic.List<System.Windows.Forms.TreeNode> result = 
                new System.Collections.Generic.List<System.Windows.Forms.TreeNode>();

            string cat = "";
            string sub = "";
            System.Windows.Forms.TreeNode catNode = null;
            System.Windows.Forms.TreeNode subNode = null;

            foreach (var skill in categories)
            {
                if (cat == skill.category)
                {
                    if (sub == skill.subcategory)
                    {
                        subNode.Nodes.Add(new System.Windows.Forms.TreeNode(skill.name));
                    }
                    else
                    {
                        sub = skill.subcategory;
                        subNode = new System.Windows.Forms.TreeNode(skill.subcategory);
                        catNode.Nodes.Add(subNode);
                    }
                }
                else
                {
                    cat = skill.category;
                    catNode = new System.Windows.Forms.TreeNode(skill.category);
                    result.Add(catNode);
                }
            }

            return result.ToArray();
        }
    }
}

/*
                if (depth == 2)
                {
                    if (catNode.Name == skill.category)
                    {
                        if (subNode.Name == skill.category)
                        {
                            subNode.Nodes.Add(new System.Windows.Forms.TreeNode(skill.name));
                        }
                        else
                        {
                            depth = 1;
                        }
                    }
                    else
                    {
                        depth = 0;
                    }
                }

                if (depth == 1)
                {
                    subNode = new System.Windows.Forms.TreeNode(skill.category);
                    catNode.Nodes.Add(subNode);
                    depth = 2;
                }

                if (depth == 0)
                {
                    catNode = new System.Windows.Forms.TreeNode(skill.category);
                    result.Add(catNode);
                    depth = 1;
                } 
*/
