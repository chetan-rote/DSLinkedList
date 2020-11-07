/******************************************************************************
 *  Purpose: Determines whether or not n is prime.
 *
 *
 *  @author  Chetan Rote
 *  @version 1.0
 *  @since   06-11-2020
 ******************************************************************************/
using System;
using System.Drawing;

namespace DSLinkedList
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Linked List.");
            ///UC1&2
            //LinkedList linkedList = new LinkedList();
            //linkedList.Add(56);
            //linkedList.Add(30);
            //linkedList.Add(70);
            //Console.WriteLine("Values in Linked List:-");
            //linkedList.Display();
            /////UC3 Appends element.
            //linkedList.Append(30);
            //linkedList.Append(70);
            /////UC4 Inserting element at given Position.
            //linkedList.InsertAtGivenPosition(2, 30);
            //Console.WriteLine("30 inserted Between 56 & 70");
            //linkedList.Display();
            /////UC5 Delete first element.
            //Console.WriteLine("Popped first element " + linkedList.Pop().data + ".\n");
            //linkedList.Display();
            /////UC6 Delete last element.
            //Console.WriteLine("Popped last element " + linkedList.PopLast().data);
            //linkedList.Display();
            /////UC7 Ability to search element.
            //Console.WriteLine("Enter the element to be searched");
            //int data = Convert.ToInt32(Console.ReadLine());

            //int position = linkedList.Search(data);
            //if (position == 0)
            //{
            //    Console.WriteLine("No such element found");
            //}
            //else
            //{
            //    Console.WriteLine("Element found at position " + position);
            //}
            /////UC8 Inserting element at middle.
            //linkedList.InsertNodeAfterParticularNode(40, 30);
            //linkedList.Display();
            /////UC9 Ability to delete middle element.
            //linkedList.DeleteMiddleNode(40);
            //linkedList.Display();
            //linkedList.Size();
            ///UC10
            SortedLinkedList sortedLinkedList = new SortedLinkedList();
            sortedLinkedList.AddElement(56);
            sortedLinkedList.AddElement(30);
            sortedLinkedList.AddElement(40);
            sortedLinkedList.AddElement(70);
            sortedLinkedList.Display();
        }
    }
}
