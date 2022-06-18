using System;
namespace Interview.CousinProblem
{
	// C# program to print cousins of a node 
	

	public class CousinScenario
	{

		// A Binary Tree Node 
		class Node
		{
			public int data;
			public Node left, right;
		}

		// A utility function to create 
		// a new Binary Tree Node 
		static Node newNode(int item)
		{
			Node temp = new Node();
			temp.data = item;
			temp.left = null;
			temp.right = null;
			return temp;
		}

		/* It returns level of the node 
		if it is present in tree, 
		otherwise returns 0.*/
		static int getLevel(Node root,
					Node node, int level)
		{
			// base cases 
			if (root == null)
				return 0;
			if (root == node)
				return level;

			// If node is present in left subtree 
			int downlevel = getLevel(root.left, node, level + 1);
			if (downlevel != 0)
				return downlevel;

			// If node is not present in left subtree 
			return getLevel(root.right, node, level + 1);
		}

		/* Print nodes at a given level 
		such that sibling of node is 
		not printed if it exists */
		static void printGivenLevel(Node root,
							Node node, int level)
		{
			// Base cases 
			if (root == null || level < 2)
				return;

			// If current node is parent of a node with 
			// given level 
			if (level == 2)
			{
				if (root.left == node || root.right == node)
					return;
				if (root.left != null)
					Console.Write(root.left.data + " ");
				if (root.right != null)
					Console.Write(root.right.data + " ");
			}

			// Recur for left and right subtrees 
			else if (level > 2)
			{
				printGivenLevel(root.left, node, level - 1);
				printGivenLevel(root.right, node, level - 1);
			}
		}

		// This function prints cousins of a given node 
		static void printCousins(Node root, Node node)
		{
			// Get level of given node 
			int level = getLevel(root, node, 1);

			// Print nodes of given level. 
			printGivenLevel(root, node, level);
		}

		// Driver code 
		public void Run()
		{
			Node root = newNode(1);
			root.left = newNode(2);
			root.right = newNode(3);
			root.left.left = newNode(4);
			root.left.right = newNode(5);
			root.left.right.right = newNode(15);
			root.right.left = newNode(6);
			root.right.right = newNode(7);
			root.right.left.right = newNode(8);

			printCousins(root, root.left.right);
		}
	}

	// This code is contributed Rajput-Ji 

}
