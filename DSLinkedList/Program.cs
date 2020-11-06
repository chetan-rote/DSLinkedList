/******************************************************************************
 *  Purpose: Determines whether or not n is prime.
 *
 *
 *  @author  Chetan Rote
 *  @version 1.0
 *  @since   06-11-2020
 ******************************************************************************/
using System;
using System.Collections.Generic;

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
            ///UC1 Create Linked List
            LinkedList linkedList = new LinkedList();
            ///Inserting elements to Linked list.
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.InsertNodeAfterParticularNode(40, 30);
            linkedList.Display();
            linkedList.Size();
            linkedList.DeleteMiddleNode(40);
            linkedList.Display();
            linkedList.Size();
        }
    }
}
