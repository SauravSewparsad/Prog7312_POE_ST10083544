using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookGame.FindingCallNumbers;

namespace BookGame
{
    public class TreeNode
    {
        public DeweyEntry Entry { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public static TreeNode BuildTree(List<DeweyEntry> entries)
        {
            if (entries.Count == 0)
            {
                return null;
            }

            int middleIndex = entries.Count / 2;
            DeweyEntry middleEntry = entries[middleIndex];

            TreeNode node = new TreeNode
            {
                Entry = middleEntry,
                Left = BuildTree(entries.GetRange(0, middleIndex)),
                Right = BuildTree(entries.GetRange(middleIndex + 1, entries.Count - middleIndex - 1))
            };

            return node;
        }

        public static TreeNode GetRandomNode(TreeNode startNode, Random random)
        {
            List<TreeNode> nodes = new List<TreeNode>();
            TraverseTree(startNode, nodes);
            return nodes.Count > 0 ? nodes[random.Next(nodes.Count)] : null;
        }

        public static TreeNode GetRandomEntryFromTree(TreeNode startNode, Random random, int targetClass)
        {
            List<TreeNode> nodes = new List<TreeNode>();
            TraverseTreeByClass(startNode, nodes, targetClass);
            return nodes.Count > 0 ? nodes[random.Next(nodes.Count)] : null;
        }

        private static void TraverseTree(TreeNode node, List<TreeNode> nodes)
        {
            if (node != null)
            {
                nodes.Add(node);
                TraverseTree(node.Left, nodes);
                TraverseTree(node.Right, nodes);
            }
        }

        private static void TraverseTreeByClass(TreeNode node, List<TreeNode> nodes, int targetClass)
        {
            if (node != null)
            {
                if (node.Entry.Level == targetClass)
                {
                    nodes.Add(node);
                }

                TraverseTreeByClass(node.Left, nodes, targetClass);
                TraverseTreeByClass(node.Right, nodes, targetClass);
            }
        }
    }

}
