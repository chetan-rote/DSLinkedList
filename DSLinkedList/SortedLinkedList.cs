using System;
using System.Collections.Generic;
using System.Text;

namespace DSLinkedList
{
    public class SortedLinkedList
    {
        public Node head;
        /// <summary>
        /// UC10
        /// Adds the element.
        /// </summary>
        /// <param name="data">The data.</param>
        public void AddElement(int data)
        {
            Node node = new Node(data);
            ///Cecks if head is null.
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                ///if head element is greater than data will add new element.
                if (head.data > data)
                {
                    node.next = head;
                    head = node;
                }
                else
                {
                    while (temp.next != null)
                    {
                        ///If temp is lesser than data then it will exchange element.
                        if (temp.next.data < data)
                            temp = temp.next;                        
                        {
                            node.next = temp.next;
                            temp.next = node;
                            return;
                        }
                    }
                    temp.next = node;
                }
            }
        }
        /// <summary>
        /// Displays this elements from linked list.
        /// </summary>
        public void Display()
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
