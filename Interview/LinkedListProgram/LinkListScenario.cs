using System;
namespace Interview.LinkedListProgram
{
    public class LinkListScenario
    {
        public LinkListScenario()
        {
        }

        public void Run()
        {
            var list = new SimpleLinkedList();
            list.AddLast("One");
            list.AddLast("Two");
            list.AddLast("3");
            list.AddLast("4");
            list.AddFirst("1");

            list.PrintAll();
        }
    }

    public class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }
    }

    public class SimpleLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void AddFirst(object data)
        {
            if(Head == null)
            {
                Head = new Node { Data = data };
                Tail = Head;
                return;
            }

            var head = new Node { Data = data, Next = Head };
            Head = head;
        }

        public void AddLast(object data)
        {
            if (Head == null)
            {
                Head = new Node { Data = data };
                Tail = Head;
                return;
            }
            
            Tail.Next = new Node { Data = data };
            Tail = Tail.Next;
        }

        public void PrintAll()
        {
            Node current = Head;
            while(current.Next != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }

            Console.WriteLine(current.Data);
        }
    }
}
