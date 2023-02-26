using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Linkedlist
    {
        public Node Head;


        public void Addatbegning(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }

        public void Addatend(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void InsertAfter(int existingData, int newData)
        {
            Node current = Head;

            while (current != null && current.Data != existingData)
            {
                current = current.Next;
            }

            if (current == null)
            {
                // for the case when existing node with the given value was not found.
                Console.WriteLine("Node with value " + existingData + " not found.");
            }
            else
            {
                Node newNode = new Node(newData);
                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public void Pop()
        {
            if (Head == null)
            {
                Console.WriteLine("You cannot pop from an empty list.");
            }

            int result = Head.Data;
            Console.WriteLine("Poped Element:" + result);
            Head = Head.Next;
        }

        public int popLast()
        {
            if (Head == null)
            {
                throw new Exception("Cannot pop from an empty list.");
            }
            else if (Head.Next == null)
            {

                int result = Head.Data;
                Head = null;
                return result;
            }
            else
            {

                Node current = Head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }


                int result = current.Next.Data;


                current.Next = null;

                return result;
            }
        }

        public void PrintList()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
