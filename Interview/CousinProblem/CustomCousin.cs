using System;
namespace Interview.CousinProblem   
{
    public class CustomCousin
    {
        public CustomCousin()
        {
        }

        static Node newNode(int item)
        {
            Node temp = new Node();
            temp.data = item;
            return temp;
        }


        public void Run()
        {

        }

        void PrintCousin(Node root, int value)
        {
            int level = GetLevel(root, value, 0);
            PrintLevelData(root, value, level);
        }

        private void PrintLevelData(Node root, int value, int level)
        {
            if(root == null || level < 2) { return; }
            if(level == 2)
            {
                if(root.left.data == value || root.right.data == value)
                {
                    return;
                }
                if(root.left != null) { Console.Write($"{root.left} "); }
                if (root.right != null) { Console.Write($"{root.right} "); }
            }
            else if(level > 2)
            {
                PrintLevelData(root.left, value, level - 1);
                PrintLevelData(root.right, value, level - 1);
            }
        }

        private int GetLevel(Node root, int value, int level)
        {
            if(root == null)
            {
                return 0;
            }

            if(value == root.data)
            {
                return level;
            }

            int leftLevel = GetLevel(root.left, value, level + 1);
            if(leftLevel != 0) { return leftLevel; }

            return GetLevel(root.right, value, level + 1);
        }
    }

    class Node
    {
        public int data;
        public Node left, right;
    }
}
