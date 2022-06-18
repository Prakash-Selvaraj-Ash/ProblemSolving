using System;
namespace Interview.Algorithms.BinarySearchTree
{
    public class BST
    {
        public BST()
        {

        }

        public void Run()
        {
            var root = new Node(1);
            root.Left = new Node(2);
            root.Right = new Node(3);

            root.Left.Left = new Node(4);
            root.Left.Right = new Node(5);

            root.Right.Right = new Node(6);

            root.PreOrder();
            Console.WriteLine();
            root.PrintInOrder();
            Console.WriteLine();
            root.PrintPostOrder();
        }
    }


    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right{ get; set; }

        public Node(int data)
        {
            Data = data;
        }

        public void PrintInOrder()
        {
            if(Left != null)
            {
                Left.PrintInOrder();
            }
            Console.Write(Data);
            if(Right != null)
            {
                Right.PrintInOrder(); 
            }
        }

        public void PreOrder()
        {
            Console.Write(Data);
            if(Left != null)
            {
                Left.PreOrder();
            }
            if(Right != null)
            {
                Right.PreOrder();
            }
        }

        public void PrintPostOrder()
        {
            if (Left != null)
            {
                Left.PrintPostOrder();
            }
            if (Right != null)
            {
                
                Right.PrintPostOrder();
            }
            Console.Write(Data);
        }

        public bool Contains(int value)
        {
            if(Data == value)
            {
                return true;
            }

            if(value < Data)
            {
                
                return Left != null
                    ? Left.Contains(value)
                    : false;
            }
            else
            {
                return Right != null
                    ? Right.Contains(value)
                    : false;
            }
        }

        public void Insert(int value)
        {
            if(value <= Data)
            {
                if(Left == null)
                {
                    Left = new Node(value);
                }
                else
                {
                    Left.Insert(value);
                }
            }
            else
            {
                if(Right == null)
                {
                    Right = new Node(value);
                }
                else
                {
                    Right.Insert(value);
                }
            }
        }
    }
}
