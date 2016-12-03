using System;
using System.Linq;
using System.Windows.Forms;

namespace MagusTools
{
    static class MTDebug
    {
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void FillTreeView(TreeView tw, int nodeCount, int maxDepth)
        {
            int depth = 0;
            TreeNode currentNode = null;

            for (int nodeNum = 0; nodeNum < nodeCount; nodeNum++)
            {
                string text = nodeNum + "_" + RandomString(8);
                TreeNode newNode = new TreeNode(text);

                if (depth == 0)
                {
                    tw.Nodes.Add(newNode);
                    currentNode = newNode;
                    depth += 1;
                }
                else
                {
                    currentNode.Nodes.Add(newNode);
                    currentNode = newNode;
                    depth += 1;

                    if (depth == maxDepth)
                        depth = 0;
                }
            }
        }

        public static void FillDataGrid(DataGridView dg)
        {
            dg.Rows.Add(RandomString(8), "3", "12 KP");
            dg.Rows.Add(RandomString(8), "4", "4 KAP");
            dg.Rows.Add(RandomString(8), "1", "2 KP");
            dg.Rows.Add(RandomString(8), "5", "48 KP");
            dg.Rows.Add(RandomString(8), "2", "3 KAP");
            dg.Rows.Add(RandomString(8), "5", "5 KAP");
            dg.Rows.Add(RandomString(8), "3", "24 KP");
        }
    }
}