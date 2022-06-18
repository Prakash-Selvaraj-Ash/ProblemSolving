using System;
using System.Collections.Generic;

namespace Interview.Algorithms
{
    public class LevelOrder
    {
        public LevelOrder()
        {
        }

        public void Run()
        {
            BTree tree_level = new BTree();
            tree_level.Root = new Node(1);
            tree_level.Root.Left = new Node(2);
            tree_level.Root.Right = new Node(3);
            tree_level.Root.Left.Left = new Node(4);
            tree_level.Root.Left.Right = new Node(5);

            Console.WriteLine("Level order traversal " +
                                "of binary tree is - ");
            tree_level.PrintNodes();
        }
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data)
        {
            Data = data;
        }
    }

    public class BTree
    {
        public Node Root { get; set; }

        public void PrintNodes()
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while(queue.Count != 0)
            {
                var node = queue.Dequeue();
                Console.WriteLine(node.Data);

                if(node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if(node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }

            
        }
    }
}
