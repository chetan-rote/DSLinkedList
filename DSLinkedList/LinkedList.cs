﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DSLinkedList
{
    class LinkedList
    {
        internal Node head;
        /// <summary>
        /// UC2
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
        /// UC3
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
        /// <summary>
        /// UC4
        /// Inserts the specified position.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="data">The data.</param>
        internal void InsertAtGivenPosition(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;
                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
        }
        /// <summary>
        /// UC5
        /// Pops the first element from Linkedlist.
        /// </summary>
        /// <returns></returns>
        internal Node Pop()
        {
            Node node = head;
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty.");
            }
            else
            {
                head = head.next;
            }
            return node;
        }
        /// <summary>
        /// UC6
        /// Pops the last element from linked list.
        /// </summary>
        /// <returns></returns>
        public Node PopLast()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty.");
                return null;
            }
            else
            {
                Node n = head;
                while (n.next.next != null)
                {
                    n = n.next;
                }
                Node removedNode = n.next;
                n.next = null;
                return removedNode;
            }
        }
    }
}
