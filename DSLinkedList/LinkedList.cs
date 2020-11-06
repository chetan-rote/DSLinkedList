using System;
using System.Collections.Generic;
using System.Text;

namespace DSLinkedList
{
    public class LinkedList
    {
        public Node head;
        /// <summary>
        /// UC2
        /// Adds the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Add(int data)
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
        public void Append(int data)
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
        public void InsertAtGivenPosition(int position, int data)
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
        public Node Pop()
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
        /// <summary>
        /// UC7
        /// Searches for the element in linked list.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public int Search(int data)
        {
            int count = 1;
            Node temp = head;
            if (this.head == null)
            {
                return 0;
            }
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return count; ;
                }
                temp = temp.next;
                count++;
            }
            return 0;
        }
        /// <summary>
        /// UC8
        /// Inserts the node after particular node.
        /// </summary>
        /// <param name="existingNode">The existing node.</param>
        /// <param name="newNode">The new node.</param>
        public void InsertNodeAfterParticularNode(int data, int dataToSearch)
        {
            int position = Search(dataToSearch);
            if (position == 0)
            {
                Console.WriteLine("No such element found");
                return;
            }
            Node node = new Node(data);
            Node temp = this.head;
            for (int i = 1; i < position; i++)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next = node;
        }
        /// <summary>
        /// UC9
        /// Deletes the middle node.
        /// </summary>
        /// <param name="data">The data.</param>
        public void DeleteMiddleNode(int data)
        {
            int position = Search(data);
            if (position == 0)
            {
                Console.WriteLine("No such element found");
                return;
            }
            Node temp = head;
            for (int i = 1; i < position - 1; i++)
            {
                temp = temp.next;
            }
            temp.next = temp.next.next;

        }
        /// <summary>
        /// UC9
        /// Gives count of elements in the linked list.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            int count = 0;
            Node temp = head;
            if (temp == null)
            {
                return 0;
            }
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine($"Linked List Size is {count}");
            return count;
        }
    }
}

