using System;
using System.Collections.Generic;
using System.Text;

namespace DSLinkedList
{
    class LinkedList
    {
        internal Node head;
        /// <summary>
        /// Adds the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        /// <summary>
        /// Displays this instance.
        /// </summary>
        internal void Display()
        {
            Node Temp = this.head;
            if (Temp == null)
            {
                Console.WriteLine("linkedlist is  empty");
                return;
            }            
            while (Temp != null)
            {
                Console.WriteLine(Temp.data + " ");
                Temp = Temp.next;
            }
        }
        /// <summary>
        /// Appends the specified element.
        /// </summary>
        /// <param name="data">The element.</param>
        internal void Append(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node node1 = head;
                while (node1.next != null)
                {
                    node1 = node1.next;
                }
                node1.next = node;
            }
            Console.WriteLine("{0} appended into linked list", node.data);
        }
    }
}
